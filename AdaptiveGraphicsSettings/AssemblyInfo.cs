using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(AdaptiveGraphicsSettings.BuildInfo.Name)]
[assembly: AssemblyDescription("Adaptive Graphics Settings for VRChat")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(AdaptiveGraphicsSettings.BuildInfo.Company)]
[assembly: AssemblyProduct(AdaptiveGraphicsSettings.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + AdaptiveGraphicsSettings.BuildInfo.Author)]
[assembly: AssemblyTrademark(AdaptiveGraphicsSettings.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(AdaptiveGraphicsSettings.BuildInfo.Version)]
[assembly: AssemblyFileVersion(AdaptiveGraphicsSettings.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(AdaptiveGraphicsSettings.AdaptiveGraphicsSettings), AdaptiveGraphicsSettings.BuildInfo.Name, AdaptiveGraphicsSettings.BuildInfo.Version, AdaptiveGraphicsSettings.BuildInfo.Author, AdaptiveGraphicsSettings.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]