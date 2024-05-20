using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BetterTerraria;
using BetterTerraria.Projectiles;

namespace BetterTerraria.Items
{
	public class RustyKnife : ModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.ThrowingKnife);
			Item.value = 50;
			Item.rare = ItemRarityID.White;
			Item.damage = 8;
			Item.shootSpeed = 7.5f;
			Item.shoot = ModContent.ProjectileType<RustyKnifeProjectile>();
			Item.consumable = true;
			Item.knockBack = 1;
			Item.maxStack = 999;
			Item.useTime = 15;
			Item.useAnimation = 15;
		}

		public override void AddRecipes()
		{

		}
	}
}
