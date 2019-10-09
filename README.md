# DeleteWalls Sample (Desktop Version)

[![.net](https://img.shields.io/badge/.net-4.5-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![Design Automation](https://img.shields.io/badge/Design%20Automation-v3-green.svg)](http://developer.autodesk.com/)
[![visual studio](https://img.shields.io/badge/Visual%20Studio-2017-green.svg)](https://www.visualstudio.com/)

## Description

DeleteWalls is a command that deletes all walls in the current file.

## Dependencies

This project was built in Visual Studio 2017. Download it [here](https://www.visualstudio.com/).

This sample references Revit 2018's `RevitAPI.dll` and `RevitAPIUI.dll`.

## Building DeleteWalls.sln

Find `RevitAPI.dll` and `RevitAPIUI.dll` in your Revit 2018 install location and note its location. 

Clone this repository and open `DeleteWalls.sln` in Visual Studio.  

In the DeleteWalls C# project, repair the references to `RevitAPI` and `RevitAPIUI`.  You can do this by removing and re-adding the references, or by opening the `DeleteWalls.csproj` for edit and manually updating the reference paths.

Build `DeleteWalls.sln` in `Release` or `Debug` configuration.

## Using DeleteWalls

Find `DeleteWalls.addin` and place in the Revit Addins folder (`C:\ProgramData\Autodesk\Revit\Addins\201*\` for Windows 7, 8, and 10).

Edit the .addin file and edit the `<Assembly>` value to point to the location of `Autodesk.DeleteWalls.Command.dll`.

Start up Revit and open a Revit file.

Under the Add-Ins ribbon tab, click the External Tools drop-down, then click DeleteWalls.

