using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using HarmonyLib;

namespace UnencryptedSettings.Patches;

/// <summary>A class containing <see cref="SettingsManager" /> patches.</summary>
[HarmonyPatch]
public class SettingsMenuPatches {
  /// <summary>A patch for <see cref="SettingsManager.SaveSettings" /> to prevent <c>settings.json</c> being encrypted when it is saved.</summary>
  /// <param name="__instance">The <see cref="SettingsManager" /> instance.</param>
  [HarmonyPrefix]
  [HarmonyPatch(typeof(SettingsManager), nameof(SettingsManager.SaveSettings))]
  public static bool SaveSettings([SuppressMessage("ReSharper", "InconsistentNaming")] SettingsManager __instance) {
    FieldInfo readWriterFieldInfo = typeof(SettingsManager).GetField("_readWriter", BindingFlags.NonPublic | BindingFlags.Instance);
    FieldInfo settingsFieldInfo = typeof(SettingsManager).GetField("_settings", BindingFlags.NonPublic | BindingFlags.Instance);

    if (readWriterFieldInfo == null) {
      Plugin.StaticLogger.LogError("Could not find \"_readWriter\" field in \"SettingsManager\". Settings file will be encrypted.");
      return true;
    }

    if (settingsFieldInfo == null) {
      Plugin.StaticLogger.LogError("Could not find \"_settings\" field in \"SettingsManager\". Settings file will be encrypted.");
      return true;
    }

    COTLDataReadWriter<SettingsData> readWriter = (COTLDataReadWriter<SettingsData>)readWriterFieldInfo.GetValue(__instance);
    SettingsData settings = (SettingsData)settingsFieldInfo.GetValue(__instance);
    readWriter.Write(settings, "settings.json", false);

    return false;
  }
}