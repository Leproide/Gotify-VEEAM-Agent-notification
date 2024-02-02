# Gotify VEEAM Agent notification
Use Gotify as a centralized Veeam Agent backup notification center

We recommend generating a token for each customer for a cleaner display of notifications.

Through the "all messages" section of Gotify, however, you can easily see failed backups by checking the red or orange dots in the relevant notification.

You need to create a task based on Veeam Agent event in windows event log.

Remember to edit the script:
1. $GotifyServer = "http://CHANGE_ME"
2. $GotifyPort = "80"  # Replace with your Gotify port
3. $GotifyToken = "CHANGE_ME"
4. title = "Customer: Example"

Dont change the charset thats broke emoji!

![immagine](https://github.com/Leproide/Gotify-VEEAM-Agent-notification/assets/8448713/2f25a7fe-6df1-4129-a3a9-84f43b554bdc)
