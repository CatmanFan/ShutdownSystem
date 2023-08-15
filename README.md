# ShutdownSystem
Basic GUI menu for shutting down a Windows computer using various methods.

Written in C# on .NET Framework 4.0.

## Features
Several methods, including undocumented functions converted from C++, can be used to trigger a shutdown of Windows OS or the computer hardware.

**Safe shutdown methods:**
- **ExitWindowsEx()**: Self-explanatory, will shutdown, logoff, or restart the system with a given shutdown reason (set to Minor/Other by default). Documentation/original code can be found [here](https://www.pinvoke.net/default.aspx/user32/ExitWindowsEx.html), or see [this article](http://jdebp.info/FGA/windows-nt-6-shutdown-process.html) for a more detailed explanation.
- **InitiateSystemShutdownEx()**: Can be used to trigger a system shutdown similar to using "shutdown.exe -t" with command line. Documentation/original code can be found [here](http://pinvoke.net/default.aspx/advapi32.initiatesystemshutdownex).

**Hard shutdown methods:**
- **NtShutdownSystem()**: Kernel (ntdll) function called at the very end of a normal Windows shutdown process. The function tells drivers to shut down, flushes disc cache and registry hive copies, clears the paging file, then calls NtSetSystemPowerState (see below). Documentation/original code can be found [here](https://www.codeproject.com/Articles/34194/Performing-emergency-shutdowns).
- **NtSetSystemPowerState()**: Kernel (ntdll) function which shuts down all plug-and-play devices and sets the CPU power status to halt, reboot or power off. Documentation/original code can be found [here](https://www.codeproject.com/Articles/34194/Performing-emergency-shutdowns).
- **SetSystemPowerState()**: Similar to NtSetSystemPowerState but meant only for smart devices, since it uses .NET Compact Framework (I have not tested this on non-desktop devices as of release). Uses coredll as base library. Documentation/original code can be found [here](https://www.pinvoke.net/default.aspx/coredll.setsystempowerstate).

**Blue Screen of Death (BSOD) methods:**
- **NtRaiseHardError()**: Returns an NT status code ([list](http://deusexmachina.uk/ntstatus.html)). If it is an error code (i.e. 0xC0000000 or above), it causes a BSOD, otherwise it will usually only return a message box. No administrator privileges are needed. For the purposes of this application, non-error codes have been removed from the list of available ones to use in the menu. Documentation/original code can be found [here](https://www.pinvoke.net/default.aspx/ntdll/NtRaiseHandError.html).
- **NtSetInformationProcess()**: Toggles the "critical" status of a particular process (here, it will use this application as the base process). Windows will automatically crash if it detects that any process set to critical has been shut down unexplicably; one example of this is "csrss.exe". For this purpose, I have simply reused most of the code from [this tutorial](https://codingvision.net/c-make-a-critical-process-bsod-if-killed) with minor edits.

## Warning
Some of the methods used to hard shutdown the computer are UNSAFE and will lead to the loss of all unsaved data if used. **It is recommended to try this application on a virtual machine instead!**

## Credits
Power icon by Cole Bemis, using MIT (Open Source) license.
