using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Materials
{
	public class LegalGunParts : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.IllegalGunParts);
			Item.value = 50000;
			Item.rare = ItemRarityID.Blue;
			Item.maxStack = 999;
			Item.useTime = 15;
			Item.useAnimation = 15;
		}
	}
}
