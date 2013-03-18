using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith("libIncrement.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, Frameworks = "Foundation", ForceLoad = true)]

