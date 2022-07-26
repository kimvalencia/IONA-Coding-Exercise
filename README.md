# IONA-Coding-Exercise
Coding Exercise for IONA Application

Prerequisite Tools
1. IIS Server 8 or later
2. .Net Core Hosting Bundle (Download here https://dotnet.microsoft.com/permalink/dotnetcore-current-windows-runtime-bundle-installer)

How to Run the Project
1. Navigate to folder named "IONACodingExercise"
2. Run "dotnet run" command.
3. Access API via "https://localhost:7215"

How to Test the Project
1. Navigate to folder named "IONACodingExercise.Test"
2. Run "dotnet test" command.

How to Setup the Project in localhost
1. Navigate to folder named "IONACodingExercise"
2. Run "dotnet publish --configuration Release"
3. Navigate to "IONACodingExercise\bin\Release\net6.0\publish"
4. Copy all contents.
5. Navigate to "C:\inetpub\wwwroot\"
6. Run "mkdir IONA"
7. Paste all contents from step 4.
8. open IISManager via "inetmgr" on console
9. Navigate to Sites > Default Web Site
10. Right Click the folder named "IONA" and Click "Convert to Application". Click "OK".
11. Open Browser and type "http://localhost/iona". You'll get an "Unauthorized Access" message.
12. To use the Web Service, add data on Headers with Key-Value of "API_KEY" as the Ket and "ac9138e7-9ca5-45ee-8122-5bf1791e7848" as the value.
13. Web Service is now ready to be used.
