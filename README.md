# Vertigo2LIV
Adds/fixes LIV support for Vertigo 2, allowing for mixed reality capture or avatars in third person.

Vertigo 2 already has older LIV integration (which somewhat worked in the demo), but due to VR/MR issues and lack of available documentation for the older integration this mod paves over it with an updated LIV SDK. Like [VertigoRemasteredLIV](https://github.com/Jas2o/VertigoRemasteredLIV) there is some graphics/alpha issues with the mod.

Please be aware that if you stop using the mod you should remove the ExternalCamera.cfg file from Vertigo 2 game folder or it may have issues being playable.

# Installation and use
- Download MelonLoader Installer and install 0.5.7 in Vertigo 2 folder.
- From the [Vertigo2LIV release zip](https://github.com/Jas2o/Vertigo2LIV/releases), extract the folder Mods into Vertigo 2 folder.
- Browse to Steam\steamapps\common\Vertigo 2\vertigo2_Data\Plugins\x86_64
    - **Rename LIV_MR.dll to something like LIV_MR.dll.disabled** (or you could move/delete it).
    - (Optional) For quieter Melon Loader log window without ForceTube haptic gunstock, rename ForceTubeVR_API_x64.dll to something like ForceTubeVR_API_x64.dll.disabled
- Start the game from Steam.
- From LIV, change Capture tab to Manual and select vertigo2.exe (not Melon Loader).
