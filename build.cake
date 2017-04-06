var target = Argument("target", "Default");

Task("Build-NET35")
    .Does(() =>
{
    MSBuild("./MultipleFrameworksDemo.sln", new MSBuildSettings ()
        .WithProperty("NetFramework", "NET35")
        .WithTarget("Rebuild"));
});

Task("Build-NET40")
    .Does(() =>
{
    MSBuild("./MultipleFrameworksDemo.sln", new MSBuildSettings ()
        .WithProperty("NetFramework", "NET40")
        .WithTarget("Rebuild")); // Important, otherwise it will reuse build from .NET 3.5
});

Task("Build-NET45")
    .Does(() =>
{
    MSBuild("./MultipleFrameworksDemo.sln", new MSBuildSettings ()
        .WithProperty("NetFramework", "NET45")
        .WithTarget("Rebuild")); // Important, otherwise it will reuse build from .NET 3.5
});

Task("Build-That-Fails")
    .Does(() =>
{
    MSBuild("./MultipleFrameworksDemo.sln", new MSBuildSettings()
        .WithTarget("Rebuild"));
});

Task("Default")
    .IsDependentOn("Build-NET35")
    .IsDependentOn("Build-NET40")
    .IsDependentOn("Build-NET45");

RunTarget(target);