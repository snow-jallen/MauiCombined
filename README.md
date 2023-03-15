# Blazor everywhere - Blazor Server, Blazor-based MAUI App, Regular MAUI app w/Blazor sprinkled in

The Razor Class Library defines components shared across two MAUI apps and a Blazor Server app.
One of the components requires an IDataSource to be injected in, and each different app injects different implementations of that interface.  The MauiRegular app injects different behavior depending on if you're running on Windows or Android as well.

|Project|Description|
|---|---|
|BlazorServerApp|Example of using those same components in a regular web app|
|MauiCombined|100% Blazor Components (no xaml pages)|
|MauiRegular|Regular MAUI app with Blazor sprinkled in|
