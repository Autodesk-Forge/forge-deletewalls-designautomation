# DeleteWalls Sample (Desktop Version)

[![.net](https://img.shields.io/badge/.net-4.7|4.8-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![visual studio](https://img.shields.io/badge/Visual%20Studio-2017|2019-green.svg)](https://www.visualstudio.com/)
[![revit](https://img.shields.io/badge/revit-2018|2019|2020|2021-red.svg)](https://www.autodesk.com/products/revit/overview/)

## Description

DeleteWalls is a command that deletes all walls in the current file.

## Dependencies

This project was built in Visual Studio 2019. Download it [here](https://www.visualstudio.com/).

This sample references Revit 2021's `RevitAPI.dll` and `RevitAPIUI.dll`.

## Building DeleteWalls.sln

Find `RevitAPI.dll` and `RevitAPIUI.dll` in your Revit 2021 install location and note its location. 

Clone this repository and open `DeleteWalls.sln` in Visual Studio.  

In the DeleteWalls C# project, repair the references  `RevitAPI` and `RevitAPIUI`.  You can do this by removing and re-adding the references, or by opening the `DeleteWalls.csproj` for edit and manually updating the reference paths.

Build `DeleteWalls.sln` in `Release` or `Debug` configuration.

__Note: Although the project will be always migrated to latest release of Revit, it should be also working with previous releases (after re-built by the corresponding references & packages).__

## Using DeleteWalls

Find `DeleteWalls.addin` and place in the Revit Addins folder (`C:\ProgramData\Autodesk\Revit\Addins\201*\` for Windows 7, 8, and 10).

Edit the .addin file and edit the `<Assembly>` value to point to the location of `Autodesk.DeleteWalls.Command.dll`.

Start up Revit and open a Revit file.

Under the Add-Ins ribbon tab, click the **External Tools** drop-down, then click **DeleteWalls**.

