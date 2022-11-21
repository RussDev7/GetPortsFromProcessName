# GetLocalApplicationAddress
This is a very basic git project to show off the working code for gathering the netstat information of running windows processes.
+ Using this code, we can get the established local / foreign network address from an windows presses.

As for demo testing purposes, we can use a textbox to specify what process to check as shown bellow.

![save](https://user-images.githubusercontent.com/33048298/203162823-6d2fb933-1b92-4f13-9c96-613dac2e7cd9.PNG)

# BatchScripting
This project was a conversion between another script I created in batch to get the local port of a running process.
```bat
@ECHO OFF

Rem | Get the PID for the Terraria process.
for /F "tokens=1,2" %%i in ('tasklist /FI "IMAGENAME eq Terraria.exe" /fo table /nh') do (

    Rem | Get the netstat for the Terraria PID.
    for /F "tokens=1,2" %%a in ('netstat -ano ^| find "%%j" ^| find "ESTABLISHED"') do (
	
	    Rem | Get only the port of the local TCP address.
        for /F "delims=: tokens=2" %%c in ('echo %%b') do (
		
		    Rem | Echo the port.
	        echo Local Port: "%%c"
	    )
    )
)
pause
```
# Live Demo:
![GetTerrariaLocalPort](https://user-images.githubusercontent.com/33048298/203161059-ddba6be4-1606-45a7-b60f-298b315b6d34.gif)
