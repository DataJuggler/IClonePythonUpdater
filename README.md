# IClonePythonUpdater
This project is used to convert IClone 7 Python Scripts to IClone 8. A work in progress at this point.

I have offically converted one file, so I can say "it works" for that file only. I know there will be more bugs and more replacements needed.

A Release Version is coming soon, once I convert a few more files.  

Instructions To use: 

Note: instructions are more detailed as some Python programmers from IClone Discord and Forums may not be familiar with Visual Studio or C#.

Clone the solution:
1. Click the Clone button, which copies the Git Url to your clipboard, then open Visual Studio and select Clone Project, and paste in the Git Url.
or 
2. download the solution as a zip file and extract to a folder.

After cloning, open IClonePythonUpdater.sln

This will open the project.

To Run: Press F5 or on the Debug Menu - Start Debugging. 

You will notice the app prepopulates the Output Folder. This is hard coded to a folder on my machine. I left this in on purpose, but you can change this value.
Open the file App.config by double clicking on it. This will bring up the Application Configuration file. 

Change the value for Output Folder to the folder you want:

<add key="OutputFolder" value="C:\Projects\GitHub\PythonScripts\IClone8" />

Next time you start the app, the Output Folder will be populated to the folder. 

I have a few modifications in place now, but I have tested even less.

To make modifications:

Open MainForm.cs by right clicking in Solution Explorer, and select - View Code. Look for a method named LoadFindAndReplaceItems in the top right hand corner 
of the text editor.

![image](https://user-images.githubusercontent.com/26331133/159132408-0f17ed42-6288-466c-acd5-ab0f96ded11b.png)

Create a new FindAndReplaceItem, and set it's values for Find and Replace. 

I am sure there will be some replacements or advanced search and replace features needed to make this more useful. I just wanted to stub 
something out and create a work in progress.

If something doesn't work, create an Issue here on this Project's Issue tab and I will try and fix it. Please attached the file that is giving you a problem.
If the file you need converted is private, you may send it to me via email. My email is listed here on Git Hub or you can email me at info@datajuggler.com 

If it helps you let me know by leaving a star.


