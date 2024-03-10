using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace UnencryptedSettings;

/// <summary>The Plugin entry point.</summary>
[BepInPlugin("com.f4iTh.COTL.UnencryptedSettings", "Unencrypted Settings", "0.1.0")]
public class Plugin : BaseUnityPlugin {
  /// <summary>A static logger instance that can be used across the entire project.</summary>
  internal static ManualLogSource StaticLogger;

  /// <summary>The Harmony instance for the plugin.</summary>
  private readonly Harmony _harmonyInstance = new("com.f4iTh.COTL.UnencryptedSettings");

  /// <inheritdoc cref="Plugin.Awake" />
  private void Awake() {
    StaticLogger = this.Logger;
  }

  /// <inheritdoc cref="Plugin.OnEnable" />
  private void OnEnable() {
    this._harmonyInstance.PatchAll();
  }

  /// <inheritdoc cref="Plugin.OnDisable" />
  private void OnDisable() {
    this._harmonyInstance.UnpatchSelf();
  }
}