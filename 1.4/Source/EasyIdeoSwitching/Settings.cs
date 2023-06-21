using UnityEngine;
using Verse;

namespace EasyIdeoSwitching
{
	public class Settings : ModSettings
	{
		public bool BlockPrimaryIdeoChanges;

		public void DoWindowContents(Rect wrect)
		{
			Listing_Standard options = new Listing_Standard();
			options.Begin(wrect);

			options.CheckboxLabeled("Block Primary Ideology Changes", ref BlockPrimaryIdeoChanges);
			options.Gap();

			options.End();
		}

		public override void ExposeData()
		{
			Scribe_Values.Look(ref BlockPrimaryIdeoChanges, "blockPrimaryIdeoChanges", true);
		}
	}
}
