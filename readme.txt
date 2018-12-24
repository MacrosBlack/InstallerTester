$test="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe"
cd D:\repos\InstallerTester\InstallerTester\bin\Release
Start-Process $test -ArgumentList "installertester.dll /Logger:trx" -Verb RunAs -Wait

