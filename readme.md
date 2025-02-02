# PKHeX Plugin Pile
This is meant to be a single repo to contain all my [PKHeX](https://github.com/kwsch/PKHeX) plugins rather than having many separate repos.

## Setup Instructions
- Download the plugins from the latest release [here](https://github.com/foohyfooh/PKHeXPluginPile/releases/latest).
- Extract and unblock them in Windows' Properties Menu.
- Put them in the *plugins* folder that is in the same directory as the PKHeX binary.

*If you are confused on the setup then you can follow the instructions from PKHeX-Plugins [here](https://github.com/architdate/PKHeX-Plugins/wiki/Installing-PKHeX-Plugins).*

## Sorting Plugin
The purpose of this plugin is to provide sorting by different regional Pokédexes.
- *Sort Boxes By* should now be in the *Tools* menu of PKHeX.

## Insertion Plugin
The purpose of this plugin is to insert an empty slot in your save file.
- *Insertion Plugin* should now be in the *Tools* menu of PKHeX. Click on it to open the form.
- Input the Box Number and Slot Number and all the Pokémon from that spot will be moved down a single slot.

## Raid Importing Plugin
The purpose of this plugin is to provide a convient way to import the raid data from [Project Pokémon Event Gallery](https://github.com/projectpokemon/EventsGallery) into Sword/Shield and Scarlet/Violet.
- *Import Raid* should now be in the *Tools* menu of PKHeX.
- Once you click the button a folder select dialog will pop up.
- Select an appropriate raid folder from the Event Gallery for the game and it should be imported.
  - For Sword/Shield, this is the folder with the blocks
  - For Scarlet/Violet, this is the folder with the Identifier.txt

## Scarlet/Violet Vivillon Plugin
The purpose of this plugin is allow a user to edit which Vivillon Spawns in Scarlet and Violet overworld without requiring GO Connectivity.
- *Vivillon Form Changer* should now be in the *Tools* menu of PKHeX. Click on it to open the form.
- Select the form you want to appear in the game and click save.

### Note
The name was going to be one of the following SVVivillonPlugin, ScViVivillonPlugin, SVivillonPlugin, ScViVillonPlugin and I just went with SVivillonPlugin.

## Start Date Editor Plugin
The purpose of this plugin is allow for editing the start date on Switch games.

## Building
- Open PowerShell and Run `build.ps1`
- Plugin should be located in `bin\Build` and `bin\PKHeXPluginPile.zip`

### Requirements
- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET](https://dotnet.microsoft.com/)

### Trouble Running PowerShell Script
- Open PowerShell As Administrator
- Run `Get-ExecutionPolicy` and note the value
- Run `Set-ExecutionPolicy Unrestricted`
- Follow the building step above
- Run `Set-ExecutionPolicy <previous execution policy value>` e.g. `Set-ExecutionPolicy AllSigned`

## Contributing Language Support
The default language for this project is English but there appears to be interest in localizing, so I have attempted to add multilingual support. The original idea was to use String Resources (resx files) as the means of multilingual support but the different language files were producing separate dll files which weren't being bundled into the plugin dll so I have added a hacky way to do multilingual support. To add support for a language that PKHeX supports, go to the desired plugin and modify the switch cases in the `Language.cs` file using the following language codes that `PKHeX.Core.GameInfo.CurrentLanguage` returns
| Key | Language            |
|-----|---------------------|
| de  | German              |
| es  | Spanish             |
| fr  | French              |
| it  | Italian             |
| ja  | Japanese            |
| ko  | Korean              |
| zh  | Simplified Chinese  |
| zh2 | Traditional Chinese |
