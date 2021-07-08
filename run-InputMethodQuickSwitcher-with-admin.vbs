Set WshShell = CreateObject("WScript.Shell" ) 
WshShell.Run """C:\tools\Input Method Quick Switcher 1.5.1\InputMethodQuickSwitcher.exe""", 0 'Must quote command if it has spaces; must escape quotes
Set WshShell = Nothing