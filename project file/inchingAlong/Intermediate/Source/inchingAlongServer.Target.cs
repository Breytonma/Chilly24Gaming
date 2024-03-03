using UnrealBuildTool;

public class inchingAlongServerTarget : TargetRules
{
	public inchingAlongServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("inchingAlong");
	}
}
