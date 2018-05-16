var target = Argument("Target", "Default");

var configuration = 
    HasArgument("Configuration") ? Argument<string>("Configuration") :
    EnvironmentVariable("Configuration") != null ? EnvironmentVariable("Configuration") : "Release";

var buildNumber =
    HasArgument("BuildNumber") ? Argument<int>("BuildNumber") :
    TravisCI.IsRunningOnTravisCI ? TravisCI.Environment.Build.BuildNumber :
    EnvironmentVariable("BuildNumber") != null ? int.Parse(EnvironmentVariable("BuildNumber")) : 0;

Task("Information")
    .Does(() => 
    {
        Information("Hello world!");
    });

// A directory path to an Artifacts directory.
var artifactsDirectory = Directory("./dist");
Task("Clean")
    .Does(() =>
    {
        CleanDirectory(artifactsDirectory);
    });
 
Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        var projects = GetFiles("./**/*.csproj");
        foreach(var project in projects)
        {
            DotNetCoreRestore(
                project.GetDirectory().FullPath,
                null);
        }
    });
var srcDir = "./**/src/**/*.csproj";
var testDir = "./**/test/**/*.csproj";

 Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
    {
        var projects = GetFiles("./**/*.csproj");
        foreach(var project in projects)
        {
            DotNetCoreBuild(
                project.GetDirectory().FullPath,
                new DotNetCoreBuildSettings()
                {
                    Configuration = configuration
                });
        }
    });

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
    {
        var projects = GetFiles(testDir);
        foreach(var project in projects)
        {
            DotNetCoreTest(
                project.GetDirectory().FullPath,
                new DotNetCoreTestSettings()
                {
                    // ArgumentCustomization = args => args
                    //     .Append("-xml")
                    //     .Append(artifactsDirectory.Path.CombineWithFilePath(project.GetFilenameWithoutExtension()).FullPath + ".xml"),
                    Configuration = configuration,
                    NoBuild = true
                });
        }
    });

Task("Default")
    .IsDependentOn("Test");

RunTarget(target);