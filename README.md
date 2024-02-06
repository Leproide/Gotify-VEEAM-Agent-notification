# Gotify VEEAM Agent notification
Use Gotify as a centralized Veeam Agent backup notification center on Windows system by powershell script.

We recommend generating a token for each customer for a cleaner display of notifications.

Through the "all messages" section of Gotify, however, you can easily see failed backups by checking the red or orange dots in the relevant notification.

You need to create a task based on Veeam Agent event in windows event log.

Remember to edit the script:

```
$GotifyServer = "http://CHANGE_ME"
$GotifyPort = "80"  # Replace with your Gotify port
$GotifyToken = "CHANGE_ME"
title = "Customer: Example"
```

Don't change the script's charset, this breaks the functionality of the emoji.

In the code you can set the max age of event registry entry for prevent duplicate notification, default 10 minute

```
($TimeDifference.TotalMinutes -gt 10)
```

*DoubleNotifications_Veeam_Gotify.ps1*

This variant sends an additional notification to another token that can be used to quickly check for failed or warning tasks

![Gotify – Mozilla Firefox_2](https://github.com/Leproide/Gotify-VEEAM-Agent-notification/assets/8448713/98a14564-24f6-4bf8-8aae-eacaaae9a23d)
