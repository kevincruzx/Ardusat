using UnrealBuildTool;

public class Ardusat : ModuleRules
{
    public Ardusat(TargetInfo target)
    {
        PrivateIncludePaths.AddRange(new string[] { "Ardusat/Private" });

        PrivateDependencyModuleNames.AddRange(
            new string[]
			{
                "Engine",
                "InputCore",
                "Core",
                "Slate",
                "SlateCore",
                "EditorStyle",
                "CoreUObject"
            }
        );
    }
}