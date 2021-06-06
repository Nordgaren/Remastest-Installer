# Dark Souls PTDE Mod "Installer"/Updater by Nordgaren
Made by Nordgaren  
This is the first program I've ever written.  

This tool uses a modified version of [UXM](https://github.com/JKAnderson/UXM) and [Yabber](https://github.com/JKAnderson/Yabber) called [Unpack Dark Souls For Modding CSharp](https://github.com/Nordgaren/Unpack-Dark-Souls-For-Modding-CSharp).  
It will unpack the Dark Souls PTDE folder selected by the user and copy over the data files in the directory the EXE is run from.  
Installer moves all files in the DATA folder it is next to to the DATA folder selected by the user. Will also look for DSFix.ini DSFixKeys.ini and d3d9_Mod.ini, back them up and put them back after copying files.  
DSCM is optional and the installer will do nothing if it isn't in the folder with it.  

Using [SoulsFormats](https://github.com/JKAnderson/SoulsFormats) by JK Anderson  
Dependencies packaged into EXE by [Costrua.Fody](https://www.nuget.org/packages/Costura.Fody/) NuGet

### Instructions
1) This EXE should be next to a DATA folder containing mod files, not the original PTDE files.
2) Select DARKSOULS.exe or paste PTDE folder (I.E. steampath/DARK SOULS PREPARE TO DIE EDITION) path and hit "Install/Update".

### Thank You

**[HotPocketRemix](https://github.com/HotPocketRemix)** for making the original UDSFM and helping me understand how to patch the EXE properly.  
**[TKGP](https://github.com/JKAnderson)** for making SoulsFormats, UXM, and Yabber.  
**[thefifthmatt](https://github.com/thefifthmatt)** for suggesting how to make the unapacker faster.  

### Patch Notes  
## v 2.3
* Updated error handling and updated UDSFMCS
## v 2.2
* Warns user if their Dark Souls folder is read only, which requires them to run as admin, instead of getting stuck at "Preparing to unpack"
## v 2.1
* added log
## V 2
* Added built in unpacker to installer.
## V 1
* Basic file mover.


