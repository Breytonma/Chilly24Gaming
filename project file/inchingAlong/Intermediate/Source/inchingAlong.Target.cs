using UnrealBuildTool;

public class inchingAlongTarget : TargetRules
{
	public inchingAlongTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("inchingAlong");
	}
}
