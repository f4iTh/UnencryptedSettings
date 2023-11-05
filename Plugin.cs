using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace UnencryptedSettings;

[BepInPlugin("com.f4iTh.COTL.UnencryptedSettings", "Unencrypted Settings", "0.1.0")]
public class Plugin : BaseUnityPlugin {
  internal static ManualLogSource StaticLogger;

  private static readonly Harmony HarmonyInstance = new("com.f4iTh.COTL.UnencryptedSettings");

  private void Awake() {
    StaticLogger = this.Logger;
  }

  private void OnEnable() {
    HarmonyInstance.PatchAll();
    this.Logger.LogInfo("\"Unencrypted Settings\" loaded.");
  }

  private void OnDisable() {
    HarmonyInstance.UnpatchSelf();
  }
}