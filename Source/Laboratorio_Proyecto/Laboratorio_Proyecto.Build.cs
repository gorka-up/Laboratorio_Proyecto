// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Laboratorio_Proyecto : ModuleRules
{
	public Laboratorio_Proyecto(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Laboratorio_Proyecto",
			"Laboratorio_Proyecto/Variant_Platforming",
			"Laboratorio_Proyecto/Variant_Platforming/Animation",
			"Laboratorio_Proyecto/Variant_Combat",
			"Laboratorio_Proyecto/Variant_Combat/AI",
			"Laboratorio_Proyecto/Variant_Combat/Animation",
			"Laboratorio_Proyecto/Variant_Combat/Gameplay",
			"Laboratorio_Proyecto/Variant_Combat/Interfaces",
			"Laboratorio_Proyecto/Variant_Combat/UI",
			"Laboratorio_Proyecto/Variant_SideScrolling",
			"Laboratorio_Proyecto/Variant_SideScrolling/AI",
			"Laboratorio_Proyecto/Variant_SideScrolling/Gameplay",
			"Laboratorio_Proyecto/Variant_SideScrolling/Interfaces",
			"Laboratorio_Proyecto/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
