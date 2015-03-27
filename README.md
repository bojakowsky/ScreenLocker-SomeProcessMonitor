# ScreenLocker-SomeProcessMonitor
Writing it for fun, always wanted to create one [C#, WinForms]

#Some sources I've used:

http://geekswithblogs.net/aghausman/archive/2009/04/26/disable-special-keys-in-win-app-c.aspx 

https://alanbondo.wordpress.com/2008/06/22/creating-a-system-tray-app-with-c/

#Yup.
It was quite fun to write the app, feel free to copy the code.

It's the tray app, that works in background, listents to registered hotkeyes n' reacts on them.

Ctrl + K opens the screenlocker, which is hard to kill. The only bug I found is to use two or more monitors to get the context of the desktop from the other, which unhides the taskbar. 

Ctrl + I opens the process monitor, which counts the minutes you spent on using certain apps.

And the lil' manager, default password is "123", moreover password is held in XML so it can be easy edited from outside.
Limit of processes per list is 30, I just discover too late that non-dynamic array is a bad idea. 
Yeah, my main goal was to practice WinForms, so I'll leave it as it is. 
