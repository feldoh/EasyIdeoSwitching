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
		public static bool Prefix(List<Ideo> ___ideosMinor)
		{
			if (!Mod.settings.BlockPrimaryIdeoChanges || !ModsConfig.IdeologyActive || Current.ProgramState != ProgramState.Playing ||
			    Find.WindowStack.IsOpen<Dialog_ConfigureIdeo>()) return true;
			___ideosMinor.Clear();
			___ideosMinor.AddRange(PawnsFinder.AllMapsCaravansAndTravelingTransportPods_Alive_FreeColonists
				.Where(p => p.HomeFaction == Faction.OfPlayer)
				.Select(p => p.Ideo)
				.Distinct());
			return false;
		}
	}
}
