# Flip-a-Gif!

![myProject](https://user-images.githubusercontent.com/122639193/234764215-6d010a68-c95c-40a3-a807-73c220ddf79d.gif)

Flip-a-Gif is a simple Windows Form program that lets users create animated Gifs by free-drawing their animations on multiple frames. Users can create as many frames as they would like, pick the frame speed (e.g. 30fps, 60 fps, etc.), and save and open their projects.

## Description

This was initially a final project for CS321: Advanced Programming Techniques but it quickly became a fun side project. You can read more about the process [here](https://drive.google.com/file/d/1Pvdz-QnHCpqaFfjNp4conShtaPGgjIfV/view?usp=sharing).

Note that this project is in no way currently completed and is still in progress.

## Getting Started

To begin, simply create a new project by either navigating to File -> New project or by pressing ctrl + shift + N. You will then be prompted to enter the name of your project, select a folder path to save your frames (you can see your individual frames before and after creating the animated Gif), and a folder path for your project. Then, create a new frame and you are ready to let your creativity take over!

When you are finished with your project (do not forget to save!), click Export to create your animated Gif. The speed at which your frames are cycled will depend on the Gif Frame Speed you entered in the Frame Menu. Note that it is in milliseconds!

Once the project is created and saved, you can open it and continue your work where you left off.

### Dependencies

Flip-a-Gif! is running on Windows .NET 7.0. It is intended and has been tested on Windows 10.

Libaries used:
* [SVG](https://github.com/svg-net/SVG) by davescriven, jvenema, mrbean-bremen, H1Gdev, Wiesław Šoltés, owaits, ddpruitt, Ralf1108, Tebjan Halm, and others
* [Newtonsoft Json.NET](https://www.newtonsoft.com/json) by James Newton-King
* [AnimatedGif](https://github.com/mrousavy/AnimatedGif) by mrousavy

### Installing

You can either download the repo or find an exe file in the releases.

### In Depth Use

![Interface](https://user-images.githubusercontent.com/122639193/234765731-f45f1fae-77a1-4114-90d9-848547a540ac.png)

#### Menus
There are currently four menus: File, Edit, Modes, Help.

File:
* New project: Create a new project. A dialog will appear to get basic information about your project.
* Open: Open a previously created project (.json file format).
* Save frame: Saves the currently displayed frame. It is saved as an image (.gif format) at the previously designated path.
* Save project: Save the entire project, including all the frames.
* Export: Create your animted gif based on the frame speed (in ms) and the frames at the designated path.

Edit:
* Undo: Undo the last stroke. It is dependant on the frame you are on, i.e. undo will undo the last stroke of the current frame.
* Redo: Redo the changes. It is also dependant on the frame you are on.
* New Frame: Create a new frame to your animated Gif.

Modes:
* Free Draw: Draw freely on the canvas with your mouse.
* Select: Select a stroke to edit its properties. [KNOWN BUG AND DOES NOT CURRENTLY WORK]

Help:
* Help me pls ;-; : To be implemented. See below in the meantime.

#### Frame Menu
Once a project is created, a menu with the frames' settings will appear. Here is where you can control your project.

* New Frame: Create a new frame to your animated Gif.
* Stroke Colour: Select the colour of your stroke on the canvas.
* Stroke Thickness: Select the thickness of your stroke. [THERE ARE SUDDENLY A LOT OF BUGS WITH THIS - WORKING ON IT!]
* Background Colour: Select the colour of your frames' background. If update is checked, it will change the background of the current frame. Otherwise, it will be the colour of the next frame's background.
* Frame Navigation: Navigate through your current frames by clicking Previous, Next, or entering the frame's number. Note that frames begin at 1.
* Gif Frame Speed: Select your animated Gif's speed at which the frames are cycled. It is in milliseconds (e.g. 30fps = 33ms, 60fps = 16ms).

#### Status Bar
The status bar at the bottom of the screen is there to help you in your project. It displays some basic information that you may find useful.

* Project: Your project's name.
* Frame: The index of the current frame.

## Help

The "Help" button is not yet implemented. However, feel free to contact me if you are running into issues.

Below is an updated list of known bugs. If you find bugs that are unlisted in the list, feel free to report them.
* Select tool does not work.
* The stroke thickness is constantly resetting after each stroke.
* Cannot click away from the stroke thickness box.
* Free Draw and Select checks are not displayed properly in the menu.
* Update background will change the strokes of the same colour as the background.
* Text inconsistancy throughout the project (especially with upper-cases). Purely visual, does not affect use.

## Authors

Antoine Dagenais Lalande

## Version History

* 0.1
    * Initial Release

## Acknowledgments

A special thank you to Prof. Christopher Diggins for his continuous support throughout the semester and to Mike Bielawski for always being ready to help me and bring a smile on my face :)

Code snippets and inspirations:
* [AnimatedGif Implementation](https://github.com/mrousavy/AnimatedGif)
* [Mike's Strokes Design](https://github.com/meBielawski/Paint_Editor)
* [Christopher Diggins' DataModel](https://github.com/cdiggins/svg-editor)
* [Updating the background bolour by Anonymous...](https://www.syncfusion.com/faq/windowsforms/bitmaps-and-images/how-do-i-overlay-one-bitmap-over-another)
* [... and Sam Saarian](https://stackoverflow.com/questions/1720160/how-do-i-fill-a-bitmap-with-a-solid-color)
* [Newtonsoft's Custom Converter](https://www.newtonsoft.com/json/help/html/CustomJsonConverterGeneric.htm)
* [Bitmap conversion to bytes by Mike Perrenoud](https://stackoverflow.com/questions/21555394/how-to-create-bitmap-from-byte-array)
