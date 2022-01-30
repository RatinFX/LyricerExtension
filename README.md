# Lyricer
VEGAS Pro Extension for the lyrics people who still use this damn software
![](preview.png)

## Usage:
"Where do I put this?" - in either one of these folders, create a new folder if it doesn't exist yet:
- `C:\Users\...\Documents\Vegas Application Extensions\`
- `C:\Users\...\AppData\Local\Vegas Pro\Application Extensions\`
- `C:\Users\...\AppData\Roaming\Vegas Pro\Application Extensions\`
- `C:\Program Data\Vegas Pro\Application Extensions\`

Tools -> Scripting -> Rescan Script Menu Folder -> click on the script name  
You can also add it to the toolbar in Options -> Customize Toolbar

## Building
Add the correct VEGAS Pro API: `ScriptPortal.Vegas.dll` (14 or after) or `Sony.Vegas.dll` (13 or before) as a Reference to build it.  
This uses my [VegasProData](https://github.com/RatinA0/VegasProData) variable collection to make my life easier

## TODO:
- [ ] Add [BetterSearch](https://github.com/RatinA0/BetterSearch/)
- [ ] EaseAutomator
