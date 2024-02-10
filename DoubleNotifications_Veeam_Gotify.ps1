Function Send-Gotify {
    Param([Parameter(Mandatory=$true)][String]$Message, [String]$Token)
    
    $GotifyServer = "YOUR SERVER"
    $GotifyPort = "80"  # Replace with your Gotify port
    
    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    
    $RequestBody = @{
        title = "CUSTOMER: EXAMPLE PC"
        message = $Message
    } | ConvertTo-Json

    try {
        $Uri = "$GotifyServer`:$GotifyPort/message"
        Write-Host "Sending Gotify message to $Uri"
        
        $Response = Invoke-RestMethod -Uri $Uri -Method Post -Headers @{
            "X-Gotify-Key" = $Token
        } -Body $RequestBody -ContentType 'application/json; charset=utf-8'

        Write-Host "Gotify message sent successfully. Response: $($Response | ConvertTo-Json -Depth 5)"
    } catch {
        Write-Host "Failed to send Gotify message. Error: $_"
    }
}


# Get the last event with ID 190
$A = Get-WinEvent -MaxEvents 1 -FilterHashTable @{Logname = "Veeam Agent"; ID = 190}

if ($A) {
    $Message = $A.Message
    $EventTime = $A.TimeCreated

    # Format the event date (not time)
    $FormattedEventDate = $EventTime.ToString("dd-MM-yyyy")

    # Check if the event date is equal to the current date
    if ($FormattedEventDate -eq (Get-Date).ToString("dd-MM-yyyy")) {
        $EventTimeString = "Event Time: $($EventTime.ToString("dd-MM-yyyy HH:mm:ss"))"

        # Check if the event is older than 10 minutes
        $TimeDifference = (Get-Date) - $EventTime
        if ($TimeDifference.TotalMinutes -gt 10) {
            exit
        }

        # Check if the event message contains "Success", "Failed", or "Warning"
        if ($Message -match "Success") {
            $CustomString = "🟢 BACKUP ESEGUITO"  # Green circle emoji
        } elseif ($Message -match "Failed") {
            $CustomString = "🔴 BACKUP FALLITO"  # Red circle emoji
            Send-Gotify -Message "$CustomString`r`n$EventTimeString`r`n$Message" -Token "APP TOKEN FOR FAILED AND WARNING"
        } elseif ($Message -match "Warning") {
            $CustomString = "🟠 WARNING!"  # Orange circle emoji
            Send-Gotify -Message "$CustomString`r`n$EventTimeString`r`n$Message" -Token "APP TOKEN FOR FAILED AND WARNING"
        }

        # Concatenate custom string, event time, and message
        $MessageToSend = "$CustomString`r`n$EventTimeString`r`n$Message"

        # Send the message via Gotify
        Send-Gotify -Message $MessageToSend -Token "PRIMARY TOKEN"
    } else {
        exit
    }
} else {
    exit
}
