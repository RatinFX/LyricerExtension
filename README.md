# Lyricer

Vegas Pro Extension for the lyrics people who still use this damn software

![](preview.png)

### Info:

something

- her

Press the help button.  
 vid:

### Running the script:

put the file in either  
...\vegas install folder\Script Menu  
or  
...\documents\Vegas Script Menu  
Tools -> Scripting -> Rescan Script Menu Folder -> click on the script name  
You can also add it to the toolbar in Options -> Customize Toolbar

### Building:

`using Sony.Vegas;` if you have vp13 and below  
`using ScriptPortal.Vegas;` if you have vp14 and above  
The script `CustomFades.dll` is created in \bin\debug\

### References:

Project -> Add reference -> Browse -> Your VEGAS install folder -> `ScriptPortal.Vegas.dll` or `Sony.Vegas.dll`

### Known bugs:

`System.IO.FileLoadException` & `System.NotSupportedExtension` for whatever reason
