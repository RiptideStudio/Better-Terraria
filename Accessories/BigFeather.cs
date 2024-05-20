using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Accessories
{
	public class BigFeather : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 4;
			Item.height = 4;
			Item.value = 15000;
			Item.rare = ItemRarityID.Blue;
			Item.accessory = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(1);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

        public override void UpdateEquip(Player player)
        {
			player.moveSpeed += 0.15f;
			player.GetModPlayer<GlobalPlayer>().superDash = true;
			player.GetModPlayer<GlobalPlayer>().dashAccessoryEquipped = true;
			player.GetModPlayer<GlobalPlayer>().dashType = GlobalPlayer.DashType.feather;
		}
    }
}
