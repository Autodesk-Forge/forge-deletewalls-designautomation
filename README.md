# DeleteWalls Sample 

[![.net](https://img.shields.io/badge/.net-4.7|4.8-green.svg)](http://www.microsoft.com/en-us/download/details.aspx?id=30653)
[![Design Automation](https://img.shields.io/badge/Design%20Automation-v3-green.svg)](https://forge.autodesk.com/en/docs/design-automation/v3/developers_guide/overview/)
[![visual studio](https://img.shields.io/badge/Visual%20Studio-2017|2019-green.svg)](https://www.visualstudio.com/)
[![revit](https://img.shields.io/badge/revit-2018|2019|2020|2021-red.svg)](https://www.autodesk.com/products/revit/overview/)

## Description

DeleteWalls is an application that takes in a rvt file and outputs another rvt file with all of the walls removed. The files in this repository are to be used as exercise files for a [tutorial](https://forge.autodesk.com/en/docs/design-automation/v3/tutorials/revit-edit/step1-convert-addin/) to convert a typical Revit add-in to a Design Automation ready Revit add-in.

This repository contains two folders. Each of them contains a C# project. Although the projects will be always migrated to latest release of Revit, it should be also working with previous releases (after re-built by the corresponding references & packages). 

- [Desktop_Version](Desktop_Version) - 
  Contains a C# project of the DeleteWalls sample, which produces an add-in that runs on the desktop version of Revit.  

- [Design-Automation_Version](Design-Automation_Version) - 
  Contains a C# project of the DeleteWalls sample, which produces an add-in that runs on  Design Automation.

Refer to the readme in each folder for details on each project.

