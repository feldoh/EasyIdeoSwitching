<p>
  <a href="https://steamcommunity.com/sharedfiles/filedetails/?id=2992791856">
  <img src="https://img.shields.io/static/v1?label=Steam&message=Workshop&color=blue&logo=steam&link=https://steamcommunity.com/sharedfiles/filedetails/?id=2992791856" alt="Steam Workshop Link"/>
  </a>
</p>

# Easy Ideo Switching

![Mod Version](https://img.shields.io/badge/Mod_Version-1.0.0-blue.svg)
![RimWorld Version](https://img.shields.io/badge/Built_for_RimWorld-1.4-blue.svg)
![Harmony Version](https://img.shields.io/badge/Powered_by_Harmony-2.3-blue.svg)\
![Steam Downloads](https://img.shields.io/steam/downloads/2992791856?colorB=blue&label=Steam+Downloads)
![GitHub Downloads](https://img.shields.io/github/downloads/feldoh/EasyIdeoSwitching/total?colorB=blue&label=GitHub+Downloads)

This mod simply adds:
* A big button on the ideology page to set your primary ideoligion.
* A big button on the ideology page to make your primary ideoligion fluid if it isn't or flip it back if it is.
  * Be warned, this is inspired by a similar button in the `Intentional Proselytism` mod, but that mod does not allow you to change it back and only allows this if there are no other pawns or factions with that ideoligion, so practically it tends to disappear early. I'm unsure why it adds this restriction given you can convert and release other pawns with your fluid ideoligion normally. Given this, be careful when using this option it will warn you if there are other pawns or factions with the target ideoligion. It is hidden by default if you have the original mod, but you can make it appear by ticking `Show the option to make an Ideoligion fluid` in the settings.

It also has an option in the settings to stop the primary changing when new people are converted so that you can run a colony with multiple ideologies where the primary one is not just the one with the most people.

This mod was made to support the Mr Samuel Streamer [Rimworld: Blood Empire collection](https://steamcommunity.com/sharedfiles/filedetails/?id=2988953577) for his [YouTube series](https://www.youtube.com/playlist?list=PLNWGkqCSwkOEi0bxBObdEGd9_pv9odh78)  

## Inspiration
* This mod is inspired by the [Character Editor](https://steamcommunity.com/sharedfiles/filedetails/?id=1874644848) button has a button to change the primary ideoligion but is hidden away.
* The fluidity changing button is inspired by the mak fluid button from [Intentional Proselytism](https://steamcommunity.com/sharedfiles/filedetails/?id=2615025149) which has a button to make an ideoligion fluid.

## Contributing
Please make a pull request with any suggestions you might have and we will be glad to consider them for inclusion.

If you are not confident with GitHub but would like to contribute consider opening an issue and one of our modding team may action it.

## Building and Releasing

*Please Note that there is no need to build the project if you just want to use it, as long as it's in your mods folder it'll work fine. You just need to make sure you're using the _Dev_ version in your mod list. Alternatively you can download the release version from the releases section*

To build the release version of this project, download this project and place it in your mods folder.
Once you have it locally, open the [solution file](1.4/Source/EasyIdeoSwitching.sln) in Visual Studio, Rider or your tool of choice and hit build.

Assuming all the paths are right this will build the latest C# binaries and collate all the files you actually need into a separate folder named `Release` which will appear in the folder where you have this mod checked out.
It will also then zip that up for you into a zip file ready to be sent to someone or played in the game.
For example if I have the project checked out in `D:\Epic\RimWorld\Mods\EasyIdeoSwitching` after I hit build I'll magically have `D:\Epic\RimWorld\Mods\EasyIdeoSwitching\Release` and `D:\Epic\RimWorld\Mods\EasyIdeoSwitching\EasyIdeoSwitching.zip`

Only the mod owner can release so this is mostly for our own documentation but anyone can build it.
If you have build issues please make a ticket here.

## Disclaimer
Portions of the materials used to create this content/mod are trademarks and/or copyrighted works of Ludeon Studios Inc. All rights reserved by Ludeon. This content/mod is not official and is not endorsed by Ludeon.

## Thanks
* MrSamuelStreamer for the content
* Ludeon for the game
* Ranger Rick for the 1.5 corner tag
