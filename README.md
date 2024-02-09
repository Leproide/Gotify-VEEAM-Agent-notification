# Gotify VEEAM Agent notification
Use Gotify as a centralized Veeam Agent backup notification center on Windows system by powershell script.

We recommend generating a token for each customer for a cleaner display of notifications.

Through the "all messages" section of Gotify, however, you can easily see failed backups by checking the red or orange dots in the relevant notification.

You need to create a task based on Veeam Agent event in windows event log.

Remember to edit the script:

```
$GotifyServer = "YOUR SERVER"
$GotifyPort = "80"  # Replace with your Gotify port
$GotifyToken = "PRIMARY TOKEN"
title = "CUSTOMER: EXAMPLE PC"
```

Don't change the script's charset, this breaks the functionality of the emoji.

In the code you can set the max age of event registry entry for prevent duplicate notification, default 10 minute

```
($TimeDifference.TotalMinutes -gt 10)
```

# DoubleNotifications_Veeam_Gotify.ps1

This variant sends an additional notification to another token that can be used to quickly check for failed or warning tasks

![Gotify – Mozilla Firefox](https://github.com/Leproide/Gotify-VEEAM-Agent-notification/assets/8448713/e25f4dd0-2d84-42e1-b15b-19749f91a1eb)

# Script generator

Now with script generator for fast editing!

You can also save and load configuration by xml file

Compatible with single and double token script

![immagine](https://github.com/Leproide/Gotify-VEEAM-Agent-notification/assets/8448713/0ec99bbd-a92f-4fb3-af99-6427fac3bf8b)

