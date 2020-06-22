# PixelEngineGUI
A project where i created some basic user controls for fun. It uses a c# ported version of the olcConsoleGameEngine, 
originally made by javidx9 and ported to c# by DevChrome (https://github.com/DevChrome/Pixel-Engine).

# How to setup the PixelEngine references
Goto https://github.com/DevChrome/Pixel-Engine and download the pixel engine, then extract it from winrar/7zip and 
place it somewhere, such as on your desktop. Then, in this project (FunPixelEngine), right click refernces>Add Reference
and click browse on the bottom right. Then find the pixelengine you downloaded, open the Libraries folder and double click
PixelEngine.dll, and that will reference it in this project.

## Other things
As of now, the controls dont inherit from any base controls, so in the Program.cs, is a class called Prog. this contains the
lists of buttons/listboxes. Buttons are standalone. but listboxes also have their own list inside for ListboxItems, and they are
stand alone.

You add controls to that list, and pass the engine Prog instance to the GameEngine.
The GameEngine is what does all the rendering. It uses foreach loops with those lists to update and then render the controls.
It also draws a circle at the mouse position because why not ;)

There's also a theme, the DarkTheme. the controls themselves access these to render the background/mouseover/clicked backgrounds.
but as of now, there's no border to the controls.

### Info about listboxes
The listbox contains a number, which, when you add items via the AddItem method, it adds the height of the given ListboxItem to that number. this allows the stacking of ListboxItems, so instead of having to manually set the Y position, the listbox automatically sets it as that number.
This is why you must call the AddItem function to add items, and not Items.Add. this could be fixed later though.
