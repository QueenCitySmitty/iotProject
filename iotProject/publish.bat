dotnet publish -r linux-arm /p:ShowLinkerSizeComparison=true 
pushd .\bin\Debug\netcoreapp3.1\linux-arm\publish
pscp -pw smitty#2916 -v -r .\* pi@192.168.0.30:/home/pi/Desktop/rpi
popd