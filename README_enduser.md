spaar's Mod Loader is currently the only Besiege mod loader out there and enables you to use many mods at once.

Many thanks to everyone who made this possible and contributed.
Special thanks go to:
	- @VapidLinus for allowing me to use his code after he was unable to continue working on his own mod loader.
	- @TheGuysYouDespise for allowing me to integrate his block loader into the mod loader.

Features
===
- Loads all mods placed in Besiege_Data/Mods.
- An in-game console to show output from the game and from mods and to enter commands to interact with mods. (Open with Ctrl+K by default)
- An in-game GUI for enabling and disabling mods without having to install/uninstall them. (Open with Ctrl+M) by default)
- An in-game key remapper for all key combinations in the mod loader itself. (Open with Ctrl+J by default)
- Update checker that will notify you about new updates.
- A graphical installer for Windows

- Many APIs to make developing mods much easier and to make mods more compatible to each other, including an API to add custom blocks.
- An in-game object explorer with many features such as showing the GameObject hierarchy and changing some values in Components. (Only in the Developer build, Open with Ctrl+O by default)

How to install
===
You can choose between two versions to download: The normal version if you just want to play Besiege with some mods and the developer version if you want to develop mods yourself.
Either way, the installation process is the same for both versions, see below for your respective platform.

Windows (Installer)
---
There is a graphical installer for Windows available. Just download ModLoader Installer.exe, save it anywhere on your computer and run it.
If the installer doesn't automatically detect it, use the Browse button to select your Besiege installation, select a version and press "Install Mod Loader".
The installation might take a while, depending on your internet connection. The program might appear to freeze during the installation but it's just working in the background.
To update the mod loader, you can just run the program again, select the new version and press Install again.

Linux & Windows (Manual Installation)
---
Locate your Besiege installation. If you installed Besiege via Steam, this will usually be in C:\Program Files (x86)\Steam\steamapps\common\Besiege.
I will from now on refer to this directory as simply Besiege in any paths.
Copy the file Assembly-UnityScript.dll into Besiege/Besiege_Data/Managed.
When asked, choose to replace the original file. You may also want to make a backup of the original file before doing this.
Then create the folder Besiege/Besiege_Data/Mods. Copy SpaarModLoader.dll, the Resources folder and the Blocks folder into it. You will also place any mods you install into this folder.

Mac OS X
---
Locate your Besiege installation (Besiege.app).
If you installed it via Steam, right-click Besiege in your Steam Library, click on Properties, go to Local Files and then click on Browse Local Files.
If you did not install via Steam, find Besiege.app manually.
Then right-click on Besiege.app and click on Show Package Content. I will from now on refer to this directory as simply Besiege in any paths.
Copy the file Assembly-UnityScript.dll into Besiege/Contents/Data/Managed. If that does not exist, try Besiege/Contents/Resources/Data/Managed.
When asked, choose to replace the original file. You may also want to make a backup of the original file before doing this.
Then create the folder Besiege/Contents/Mods. Copy SpaarModLoader.dll, the Resources and the Blocks folder into it. You will also place any mods you install into this folder.

That's it, the mod loader should now be installed. If you have any problems or questions, just ask on the forum and I will do my best to help.

Reporting bugs and other assistance
===
You can report bugs and ask question using (GitHub Issues)[https://github.com/spaar/besiege-modloader/issues]. If you don't have a GitHub account and don't want to create one or can't use GitHub for other reasons, posting on the forum thread is also an option. However GitHub is preferred, so please use that if you can.
Include your OS, your Besiege version and your mod loader version in a bug report, as well as a list of all mods you have installed. If you aren't using the newest version of both Besiege and the mod loader, please check if the bug still occurs in the newest version before reporting it.

For Mod developers
===
To get started, take a look at the [Visual Studio template](http://forum.spiderlinggames.co.uk/index.php?threads/new-visual-studio-template-spaar-s-mod-loader-1-x-x-mod-development.2027/).
The mod loader also has an [online documentation](http://spaar.github.io/besiege-modloader) for its various APIs.
Lastly, as a mod developer you can PM me your email address and I will add you to the [Besiege Modding Slack team](http://forum.spiderlinggames.co.uk/index.php?threads/slack-team.1148/),
where you can ask me and many other modders for assistance.

License and Source code
===
The mod loader is an open-source project licensed under the MIT license.
In the developer version, a build of Mono.Cecil is included, which follows a similiar license.
Take a look at the [GitHub page](https://github.com/spaar/besiege-modloader) for details. Contributions in the form of pull-requests or issues are always welcome!


See the Changelog.md file for a list of changes each version.
