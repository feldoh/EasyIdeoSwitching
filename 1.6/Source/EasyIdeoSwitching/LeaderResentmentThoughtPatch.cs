using System.Linq;
using HarmonyLib;
using RimWorld;
using Verse;

namespace EasyIdeoSwitching;

[HarmonyPatch(typeof(ThoughtWorker_Precept_LeaderResentment), "ShouldHaveThought")]
public static class LeaderResentmentThoughtPatch
{
	[HarmonyPostfix]
	public static ThoughtState PostFix(ThoughtState result, Pawn p)
	{
		return !result.Active || !Mod.settings.LedByConsidersIdeoRoles
			? result
			: p.Ideo.RolesListForReading.Exists(r => r.def.leaderRole && r.Active && r.ChosenPawns().Any());
	}
}
