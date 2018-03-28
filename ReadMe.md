## GS Real Time Testing Tool ##
* For more information about GameSparks visit: [http://www.gamesparks.com](http://www.gamesparks.com)
* Documentation and Tutorials can be found at: [https://docs.gamesparks.net](https://docs.gamesparks.net)
* For Support visit: [https://support.gamesparks.net/support/home](https://support.gamesparks.net/support/home)

### Steps to build client ###
1. Download and open in Unity.
2. Setup a Real Time match configuration from the [GameSparks](https://portal2.gamesparks.net/) portal.
3. From Unity edit the Gamesparks settings and place the API Key and Secret.
4. Build the application.

### Steps to use application ###
1. Start application.
2. Authenticate with a valid username and password, if the account doesn't exist the application will attempt a registration.
3. Enter a skill and valid matchShort, previously setup in the portal.
4. Repeat steps for second instance, make sure to use to a different user account.

### Steps to debug using application ###
1. The application has two preconfigured packets. One is a timestamp ping/pong packet that attempts to determine the round trip and lag of the real time session, using only the clients from within the session.
2. The second is a blank packet in which the opCode can be easily changed from the GUI interface. Being able to specifiy the opCode enables much easier server side debuging. This packet can be very easily changed from the PacketService class.
