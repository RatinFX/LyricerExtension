# Lyricer
VEGAS Pro Extension for the lyrics people who still use this damn software
![](preview.png)


## Usage
Place the contents of the .zip in the following folder, you have to create it, if it doesn't exist yet:
- `C:\Users\...\Documents\Vegas Application Extensions\`

Tools -> Scripting -> Rescan Script Menu Folder -> click on the script name  
You can also add it to the toolbar in Options -> Customize Toolbar

## Build
Add the correct VEGAS Pro API: `ScriptPortal.Vegas.dll` (14 or after) or `Sony.Vegas.dll` (13 or before) as a Reference to build it.  
This uses my [VegasProData](https://github.com/RatinA0/VegasProData) variable collection to make my life easier

## TODO:
- [ ] Remove every added extension / script, rethink the purpose of this project
