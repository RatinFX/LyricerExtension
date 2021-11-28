# Lyricer

Vegas Pro Extension for the lyrics people who still use this damn software

![](preview.png)

### TODO:

- add s\_\* presets

### Info:

- 1
- 2

Press the help button.  
 vid:

### Running the script:

Put the file in either one of these locations, you'll have to create a folder if it doesn't exist yet  
C:\Users\\...\Documents\Vegas Application Extensions\  
C:\Users\\...\AppData\Local\Vegas Pro\Application Extensions\  
C:\Users\\...\AppData\Roaming\Vegas Pro\Application Extensions\  
C:\Program Data\Vegas Pro\Application Extensions\

Tools -> Scripting -> Rescan Script Menu Folder -> click on the script name  
You can also add it to the toolbar in Options -> Customize Toolbar

### Building:

`using Sony.Vegas;` if you have VP13 and below  
`using ScriptPortal.Vegas;` if you have VP14 and above
The script `Lyricer.dll` is created in \bin\debug\
