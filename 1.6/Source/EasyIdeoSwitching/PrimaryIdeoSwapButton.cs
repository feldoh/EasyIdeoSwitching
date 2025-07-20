using System.Linq;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

namespace EasyIdeoSwitching
{
	[HarmonyPatch(typeof(IdeoUIUtility), nameof(IdeoUIUtility.DoNameAndSymbol))]
	public static class PrimaryIdeoSwapButton
	{
		public static void FlipFluid(Ideo ideo)
		{
			ideo.Fluid = !ideo.Fluid;
			if (ideo.Fluid)
				ideo.development.reformCount = ideo.memes.Count - IdeoUtility.MinFluidIdeoNormalMemes;
			else ideo.development = null;
		}

		[HarmonyPostfix]
		public static void Postfix(ref float curY, float width, Ideo ideo)
		{
			if (Find.WindowStack.currentlyDrawnWindow is Dialog_ChooseMemes) return;
			if (Faction.OfPlayer.ideos.IsPrimary(ideo))
			{
				if (!ideo.Fluid && !Mod.settings.ShowMakeFluidOption) return;
				if (Widgets.ButtonText(new Rect(width / 2.0f - 100, curY, 200f, 40f),
					    (ideo.Fluid ? "EasyIdeoSwitching_MakeNonFluidButton" : "EasyIdeoSwitching_MakeFluidButton").Translate()))
				{
					TaggedString fluidityChangeInfo = (ideo.Fluid ? "EasyIdeoSwitching_MakeNonFluidButton_Info" : "EasyIdeoSwitching_MakeFluidButton_Info").Translate();
					var factionsWithIdeo = Find.FactionManager.AllFactions.Count(f => !f.IsPlayer && (f.ideos?.Has(ideo) ?? false));
					var pawnsWithIdeo = PawnsFinder.AllMapsAndWorld_Alive.Count(p => p.Faction != Faction.OfPlayer && p.Ideo == ideo);
					if (factionsWithIdeo > 0 || pawnsWithIdeo > 0) fluidityChangeInfo = $"\n\n{"EasyIdeoSwitching_MakeFluidButton_Warning".Translate(factionsWithIdeo, pawnsWithIdeo)}";
					Find.WindowStack.Add(Dialog_MessageBox.CreateConfirmation(fluidityChangeInfo,
						() => FlipFluid(ideo), true,
						"EasyIdeoSwitching_MakeFluidButton_ChangeFluidTitle".Translate()));
				}
			}
			else if (Widgets.ButtonText(new Rect(width / 2.0f - 100, curY, 200f, 40f), "EasyIdeoSwitching_MakePrimaryButton".Translate()))
			{
				Faction.OfPlayer.ideos.SetPrimary(ideo);
			}

			curY += 17f;
		}
	}
}
