# Week-06

## Artists & Projects

+ [Shoal](http://shakethatbutton.com/shoal/)

## Tuesday

### "INPUT" Project Workshop

+ Introducing "The Google Rule"
	+ If you ask a question that can be answered by typing it into Google and viewing the first page of results, think again.

## Thursday

### Video Capture

+ Camera
	+ Clear flag, background color, [framerates](fps.gif), oh my!
+ snapshot.cs
	+ Take a single photo by pressing the S key, using [ScreenCapture.CaptureScreenshot](https://docs.unity3d.com/ScriptReference/ScreenCapture.CaptureScreenshot.html)
+ capture.cs
	+ Automatically saves every successive frame
+ Image Sequence -> GIF in Photoshop
	1. Open Photoshop
	2. File -> Open
	3. Options -> Image Sequence
	4. Select the first image in the sequence, and open
	5. Make sure to match the FPS from Unity capture.cs
	6. File -> Export -> Save for Web (Legacy)
	7. Select GIF from the preset area (higher numbers are higher quality)
	8. Check that your resolution isn't higher than 800 pixels~
	9. Save!
+ Image Sequence -> MP4 in Photoshop
	+ Steps 1 -> 5 from above
	6. File -> Export -> Render Video
	7. Save!
+ Image Sequence -> MP4 in FFmpeg
	1. cd into screenshot folder
	2. `ffmpeg -framerate 30 -i frame%04d.png -c:v libx264 -r 24 -pix_fmt yuv420p out.mp4`

## Tutorials

The following are supplemental to what we go over in class. I encourage you to review these guides on your own time.

+ [Cameras](https://unity3d.com/learn/tutorials/topics/graphics/cameras)
+ [View More Tutorials](https://unity3d.com/learn/tutorials)

## Homework
+ Create documentation for your Project 1 repo
	+ Include a brief 3-8 sentence description of your project.
	+ Include clear instructions on how to play/interact.
	+ Include a .gif or screenshot [how to](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet#images)