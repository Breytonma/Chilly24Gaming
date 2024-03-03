using UnrealBuildTool;

public class inchingAlongClientTarget : TargetRules
{
	public inchingAlongClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("inchingAlong");
	}
}
