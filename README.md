# VisitsTracker
This package was made for Umbraco solutions, and can be used to track visits to your content!

## Prerequisites
This project is made with **.NET 6**, so the minimum requirement is the `.NET SDK 6.0.302 `

## Getting started
After installing this package, all you have to do is inject the `ITrackingService` into each of your razor templates,
and call the `ReportVisit(int contentId)` method where you pass the contents id, like so:

```csharp
@using TrackerPackage.Services
@inject ITrackingService TrackingService;
@{
    TrackingService.ReportVisit(Model.Id);
}
```
This does get tedious if you have a lot of templates though! But you are in luck, if all your views has a master template, you can just inject the above in your master template instead!
(Most typical master template is the `_Layout.cshtml` file)

# How to work with this package
When you have made some changes you then want to change, open a terminal in the root of this project, and run the following command: `dotnet pack --configuration Release /p:Version=1.0.0-rc001 --output .\Release`
This will generate a nuget package file in the Release directory. 
In your umbraco project, you can then either add the nuget source manually through your IDE, and then install the package.
Or you can run the following command in the root of your umbraco project:
`dotnet add package TrackerPackage -s {{PATH TO YOUR PACKAGE RELEASE FOLDER HERE}} --prerelease`
Real example: 
`dotnet add package TrackerPackage -s C:\Users\Zeegan\Documents\GitHub\VisitsTracker\Release --prerelease`

