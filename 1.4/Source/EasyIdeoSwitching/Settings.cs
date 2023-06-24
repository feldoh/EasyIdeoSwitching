using UnityEngine;
using Verse;

namespace EasyIdeoSwitching
{
	public class Settings : ModSettings
	{
		public bool BlockPrimaryIdeoChanges;
		public bool ShowMakeFluidOption;

		public void DoWindowContents(Rect wrect)
		{
			Listing_Standard options = new();
			options.Begin(wrect);

			options.CheckboxLabeled("EasyIdeoSwitching_BlockPrimaryIdeologyChanges".Translate(), ref BlockPrimaryIdeoChanges);
			options.CheckboxLabeled("EasyIdeoSwitching_AllowChangingFluidity".Translate(), ref ShowMakeFluidOption);
			options.Gap();

			options.End();
		}

		public override void ExposeData()
		{
			Scribe_Values.Look(ref BlockPrimaryIdeoChanges, "blockPrimaryIdeoChanges", true);
			Scribe_Values.Look(ref ShowMakeFluidOption, "showMakeFluidOption", ModLister.GetActiveModWithIdentifier("ordpus.intentionalproselytism") == null);
		}
	}
}
