Function Send-Gotify {
    Param([Parameter(Mandatory=$true)][String]$Message)
    
    $GotifyServer = "http://CHANGE_ME"
    $GotifyPort = "80"  # Replace with your Gotify port
    $GotifyToken = "CHANGE_ME"
    
    [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
    
    $RequestBody = @{
        title = "Customer: Example"
        message = $Message
    } | ConvertTo-Json

    try {
        $Uri = "$GotifyServer`:$GotifyPort/message"
        Write-Host "Sending Gotify message to $Uri"
        
        $Response = Invoke-RestMethod -Uri $Uri -Method Post -Headers @{
            "X-Gotify-Key" = $GotifyToken
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

    # Check if the event message contains "Success", "Failed", or "Warning"
    if ($Message -match "Success") {
        $CustomString = "🟢 BACKUP SUCCESS"  # Green circle emoji
    } elseif ($Message -match "Failed") {
        $CustomString = "🔴 BACKUP FAILED"  # Red circle emoji
    } elseif ($Message -match "Warning") {
        $CustomString = "🟠 BACKUP WARNING!"  # Orange circle emoji
    }

    # Check if the event date is equal to the current date
    if ($FormattedEventDate -eq (Get-Date).ToString("dd-MM-yyyy")) {
        $EventTimeString = "Event Time: $($EventTime.ToString("dd-MM-yyyy HH:mm:ss"))"

        # Check if the event is older than 10 minutes
        $TimeDifference = (Get-Date) - $EventTime
        if ($TimeDifference.TotalMinutes -gt 10) {
            exit
        }

        # Concatenate custom string, event time, and message
        $MessageToSend = "$CustomString`r`n$EventTimeString`r`n$Message"

        # Send the message via Gotify
        Send-Gotify $MessageToSend
    } else {
        exit
    }
} else {
    exit
}
