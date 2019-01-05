# Wm3Util_Sample
Sample project using Wm3Util

## What is this?

This project is a sample you can just build, run and explore. It is showing Wm3Util in use.


## What is Wm3Util?

Wm3Util is a set of import scripts for the Unity Engine in order to load .wm3 files created by A3Tools.
A3Tools is a separate tool based on the Acknex8 engine, which converts Acknex3 raycaster levels to 3d meshes.
The .wm3 format was developed with Acknex8 use in mind, but it theoretically can be used in any engine. 

As Acknex8 does not feature a WYSIWYG development environment, it is very tedious to refine .wm3 levels.
To overcome this, Wm3Util was developed, since Unity allows for more comfortable scene/level editing.

The Wm3Util project can be obtained from Github: 
[https://github.com/firoball/Wm3Util_sample](https://github.com/firoball/Wm3Util_sample)


## What is A3Tools?

A3Tools is a converter for raycaster sector/wall based levels (similar to 1993 Doom) created with the Acknex3 engine.
This toolset is by far not completed, but still allows to convert many A3 levels (static only).
A3Tools can export .wm3 files and .bmp textures, which allows for import into pretty much any 3d engine of choice.

The .wm3 format was developed having usage in Acknex8 in mind, though. Format is documented in A3Tools manual.

A3Tools utilizes the Acknex8 engine to operate, Windows binaries are included. The A3Tools project can be obtained from Github: 
[https://github.com/firoball/A3Tools](https://github.com/firoball/A3Tools)


## Which manual changes were done?

While the import process runs automatically, some additional manual work was applied to this sample:
* Imported several .wm3 files. 
* Renamed *generated* folders so they are not overwritten by the next import process
* Merged several .wm3 imports into single scene
* Made doors and enemies passable for better exploration experience
* Covered all perma-death pitfalls with invisible planes
* Added simple level change system
* Added FPSControllers for navigation


## Where can I "play"?

A WebGL version was uploaded at:
[http://firoball.de/unity/kandoria](http://firoball.de/unity/kandoria)
Requires a WebGL and Javascript capable browser.


## How do I "play"?

* Move - WASD
* Look - Mouse
* Jump - Space
* Lock mouse - click into graphic area
* Unlock mouse - Esc


## Future Development

This was a Unity learning project for me and is finished as such.


## Compatibility

Wm3Util_sample was developed and tested with Unity Version 2018.3.0f2 Personal.
Downwards compatibility was not tested.
Test build were done successfully for Windows and WebGL (browser) platforms.


## Legal stuff

Please respect [license.txt](license.txt) (Attribution-NonCommercial 4.0 International)

-firoball

[http://firoball.de](http://firoball.de)
