# DeleteWalls Sample (Design Automation Version)

[![.net](https://img.shields.io/badge/.net-4.7|4.8-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![Design Automation](https://img.shields.io/badge/Design%20Automation-v3-green.svg)](https://forge.autodesk.com/en/docs/design-automation/v3/developers_guide/overview/)
[![visual studio](https://img.shields.io/badge/Visual%20Studio-2017|2019-green.svg)](https://www.visualstudio.com/)
[![revit](https://img.shields.io/badge/revit-2018|2019|2020|2021-red.svg)](https://www.autodesk.com/products/revit/overview/)

## Description

DeleteWalls is an application that takes in a rvt file and outputs another rvt file with all of the walls removed.

## Dependencies

This project was built in Visual Studio 2019. Download it [here](https://www.visualstudio.com/).

This sample references Revit 2021's `RevitAPI.dll` and Nuget pakcage [DesignAutomationBridge](https://www.nuget.org/packages/Autodesk.Forge.DesignAutomation.Revit) for Revit 2021.

In order to POST appbundles, activities, and workitems you must have credentials for [Forge](../Docs/Forge.md).

## Build DeleteWalls.sln

Clone this repository and open `DeleteWalls.sln` in Visual Studio.  

In the DeleteWalls C# project, repair the references to `DesignAutomationBridge` and `RevitAPI`.  You can do this by removing and re-adding the references `RevitAPI`, or by opening the `DeleteWalls.csproj` for edit and manually updating the reference paths.
Find `RevitAPI.dll` in your Revit 2021 install location and note its location. 

Restore [DesignAutomationBridge](https://www.nuget.org/packages/Autodesk.Forge.DesignAutomation.Revit) for Revit 2021. DesignAutomationBridge.dlls for other Revit versions can also be found in the same [gallery](https://www.nuget.org/packages/Autodesk.Forge.DesignAutomation.Revit).

Build `DeleteWalls.sln` in `Release` or `Debug` configuration.

## Run Design Automation Plugin Locally

1. Clone the other repository and find the corresponding version of test handler (such as DesignAutomationHandler2021)
        
        https://github.com/Autodesk-Forge/design.automation-csharp-revit.local.debug.tool
2. Build the test handler project. 

3. Start to debug `DeleteWalls.sln`
4. Under the Add-Ins ribbon tab, click the **External Tools** drop-down, then click **DesignAutomationHandler**. It will start to run **DeleteWalls** plugin. Set a breakpoint to debug.