using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Vertigo2.Player;

namespace Vertigo2LIV {
    [HarmonyPatch]
    public static class Patches {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(VertigoPlayer), "Init")]
        private static void SetUpLiv(VertigoPlayer __instance) {
            MelonLogger.Msg("## Patches : Player-Init-SetUpLiv ##");
            Vertigo2LIVMod.OnPlayerReady();
        }

        /*
        [HarmonyPostfix]
        [HarmonyPatch(typeof(LIVVertigoConfigurator), "Awake")]
        private static void SetUpLiv(LIVVertigoConfigurator __instance) {
            MelonLogger.Msg("## Patches : LIVVertigoConfigurator-Awake-SetUpLiv ##");
            Vertigo2LIVMod.OnPlayerReady();
        }
        */
    }
}
