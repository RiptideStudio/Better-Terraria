using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BetterTerraria;
using BetterTerraria.Projectiles;

namespace BetterTerraria.Items
{
	public class FlamingDagger : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ThrowingKnife);
			Item.value = 50;
			Item.rare = ItemRarityID.Blue;
			Item.damage = 9;
			Item.shootSpeed = 7.75f;
			Item.shoot = ModContent.ProjectileType<FlamingDaggerProjectile>();
			Item.consumable = true;
			Item.knockBack = 1.25f;
			Item.maxStack = 999;
			Item.useTime = 15;
			Item.useAnimation = 15;
		}

		public override void AddRecipes()
		{
	
		}
	}
}
