using ObjCRuntime;

[assembly: LinkWith ("MyFrameworkObjC.a",
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64,
	SmartLink = true,
	ForceLoad = true)]
