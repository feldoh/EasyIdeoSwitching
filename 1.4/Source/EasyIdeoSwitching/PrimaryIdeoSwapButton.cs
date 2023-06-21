using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace EasyIdeoSwitching
{
	[HarmonyPatch(typeof(IdeoUIUtility), nameof(IdeoUIUtility.DoNameAndSymbol))]
	public static class PrimaryIdeoSwapButton
	{
		[HarmonyPostfix]
		public static void Postfix(ref float curY, float width, Ideo ideo)
		{
			if (Faction.OfPlayer.ideos.IsPrimary(ideo)) return;
			if (Widgets.ButtonText(new Rect(width / 2.0f - 100, curY, 200f, 40f), "Make Primary"))
			{
				Faction.OfPlayer.ideos.SetPrimary(ideo);
			}

			curY += 17f;
		}
	}
}
