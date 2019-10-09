# DeleteWalls Sample (Design Automation Version)

[![.net](https://img.shields.io/badge/.net-4.5-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![Design Automation](https://img.shields.io/badge/Design%20Automation-v3-green.svg)](http://developer.autodesk.com/)
[![visual studio](https://img.shields.io/badge/Visual%20Studio-2017-green.svg)](https://www.visualstudio.com/)

## Description

DeleteWalls is an application that takes in a rvt file and outputs another rvt file with all of the walls removed.

## Dependencies

This project was built in Visual Studio 2017. Download it [here](https://www.visualstudio.com/).

This sample references Revit 2018's `RevitAPI.dll` and [DesignAutomationBridge.dll](https://revitio.s3.amazonaws.com/documentation/DesignAutomationBridge.dll) for Revit 2018.

In order to POST appbundles, activities, and workitems you must have credentials for [Forge](../Docs/Forge.md).

## Building DeleteWalls.sln

Download [DesignAutomationBridge.dll](https://revitio.s3.amazonaws.com/documentation/DesignAutomationBridge.dll) for Revit 2018. DesignAutomationBridge.dlls for other Revit versions can be found [here](../Docs/AppBundle.md#engine-version-aliases).

Find `RevitAPI.dll` in your Revit 2018 install location and note its location. 

Clone this repository and open `DeleteWalls.sln` in Visual Studio.  

In the DeleteWalls C# project, repair the references to `DesignAutomationBridge` and `RevitAPI`.  You can do this by removing and re-adding the references, or by opening the `DeleteWalls.csproj` for edit and manually updating the reference paths.

Build `DeleteWalls.sln` in `Release` or `Debug` configuration.


