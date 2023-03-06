Set WshShell = CreateObject("WScript.Shell" ) 
WshShell.Run """C:\code\github-gcc\input-method-switcher\InputMethodQuickSwitcher\bin\Debug\InputMethodQuickSwitcher.exe""", 0 'Must quote command if it has spaces; must escape quotes
Set WshShell = Nothing
