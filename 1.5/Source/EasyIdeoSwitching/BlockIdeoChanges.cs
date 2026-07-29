using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace EasyIdeoSwitching
{
	[HarmonyPatch(typeof(FactionIdeosTracker), nameof(FactionIdeosTracker.RecalculateIdeosBasedOnPlayerPawns))]
	public static class BlockIdeoChanges
	{
		[HarmonyPrefix]
		public static bool Prefix(FactionIdeosTracker __instance, List<Ideo> ___ideosMinor)
		{
			if (!Mod.settings.BlockPrimaryIdeoChanges || !ModsConfig.IdeologyActive || Current.ProgramState != ProgramState.Playing ||
			    Find.WindowStack.IsOpen<Dialog_ConfigureIdeo>()) return true;
			___ideosMinor.Clear();
			___ideosMinor.AddRange(PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_FreeColonists
				.Where(p => p.HomeFaction == Faction.OfPlayer)
				.Select(p => p.Ideo)
				.Where(ideo => ideo != null && ideo != __instance.PrimaryIdeo)
				.Distinct());
			return false;
		}
	}
}
