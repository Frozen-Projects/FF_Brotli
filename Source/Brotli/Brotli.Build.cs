namespace UnrealBuildTool.Rules
{
    using System.IO;

    public class Brotli : ModuleRules
    {
        public Brotli(ReadOnlyTargetRules Target) : base(Target)
        {
            Type = ModuleType.External;
            CppCompileWarningSettings.UndefinedIdentifierWarningLevel = WarningLevel.Off;
            bEnableExceptions = true;
            bUseRTTI = true;

            if (Target.Platform == UnrealTargetPlatform.Win64)
            {
                PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Win64", "include"));
                PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Win64", "lib", "brotlicommon.lib"));
                PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Win64", "lib", "brotlidec.lib"));
                PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Win64", "lib", "brotlienc.lib"));
            }
        }
    }
}
