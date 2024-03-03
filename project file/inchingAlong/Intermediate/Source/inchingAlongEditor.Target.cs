using UnrealBuildTool;

public class inchingAlongEditorTarget : TargetRules
{
	public inchingAlongEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("inchingAlong");
	}
}
