using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using BetterTerraria.Materials;
using BetterTerraria.Accessories;
using BetterTerraria.Common;

namespace BetterTerraria
{
    public class WorldSystem : ModSystem
    {
        // Names of recipe groups for easy use
        string anyGoldBarName = BarNames.AnyGoldBar;
        string anySilverBarName = BarNames.AnySilverBar;
        string anyCopperBarName = BarNames.AnyCopperBar;

        public override void AddRecipeGroups()
        {
            // Create a recipe group and store it
            RecipeGroup goldOrPlatinum = new RecipeGroup(() => anyGoldBarName, ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup silverOrTungsten = new RecipeGroup(() => anySilverBarName, ItemID.SilverBar, ItemID.TungstenBar);
            RecipeGroup copperOrTin = new RecipeGroup(() => anyCopperBarName, ItemID.CopperBar, ItemID.TinBar);

            RecipeGroup.RegisterGroup(anyGoldBarName, silverOrTungsten);
            RecipeGroup.RegisterGroup(anySilverBarName, goldOrPlatinum);
            RecipeGroup.RegisterGroup(anyCopperBarName, copperOrTin);
        }

        /// <summary>
        /// Add Bar conversions here
        /// </summary>
        public override void AddRecipes()
        {
            Recipe ironBar = Recipe.Create(ItemID.IronBar, 1);
            ironBar.AddIngredient(ItemID.LeadBar, 1);
            ironBar.Register();

            Recipe leadBar = Recipe.Create(ItemID.LeadBar, 1);
            leadBar.AddIngredient(ItemID.IronBar, 1);
            leadBar.Register();

            Recipe copperBar = Recipe.Create(ItemID.CopperBar, 1);
            copperBar.AddIngredient(ItemID.TinBar, 1);
            copperBar.Register();

            Recipe tinBar = Recipe.Create(ItemID.TinBar, 1);
            tinBar.AddIngredient(ItemID.CopperBar, 1);
            tinBar.Register();

            Recipe goldBar = Recipe.Create(ItemID.GoldBar, 1);
            goldBar.AddIngredient(ItemID.PlatinumBar, 1);
            goldBar.Register();

            Recipe platinumBar = Recipe.Create(ItemID.PlatinumBar, 1);
            platinumBar.AddIngredient(ItemID.GoldBar, 1);
            platinumBar.Register();
        }

        /// <summary>
        /// Remove ingredients from some recipes
        /// </summary>
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                // Mana crystal
                if (recipe.HasResult(ItemID.ManaCrystal))
                {
                    recipe.RemoveIngredient(ItemID.FallenStar);
                    recipe.AddIngredient(ItemID.FallenStar, 3);
                }
                // Frostburn arrows
                if (recipe.HasResult(ItemID.FrostburnArrow))
                {
                    recipe.RemoveIngredient(ItemID.IceTorch);
                    recipe.AddIngredient(ItemID.IceTorch, 3);
                }
                // Copper armor
                if (recipe.HasResult(ItemID.CopperHelmet))
                {
                    recipe.RemoveIngredient(ItemID.CopperBar);
                    recipe.AddIngredient(ItemID.CopperBar, 10);
                    recipe.AddIngredient(ItemID.Amethyst, 1);
                }
                if (recipe.HasResult(ItemID.CopperGreaves))
                {
                    recipe.RemoveIngredient(ItemID.CopperBar);
                    recipe.AddIngredient(ItemID.CopperBar, 15);
                    recipe.AddIngredient(ItemID.Amethyst, 1);
                }
                if (recipe.HasResult(ItemID.CopperChainmail))
                {
                    recipe.RemoveIngredient(ItemID.CopperBar);
                    recipe.AddIngredient(ItemID.CopperBar, 20);
                    recipe.AddIngredient(ItemID.Amethyst, 1);
                }
                // Tin armor
                if (recipe.HasResult(ItemID.TinHelmet))
                {
                    recipe.RemoveIngredient(ItemID.TinBar);
                    recipe.AddIngredient(ItemID.TinBar, 10);
                    recipe.AddIngredient(ItemID.Topaz, 1);
                }
                if (recipe.HasResult(ItemID.TinGreaves))
                {
                    recipe.RemoveIngredient(ItemID.TinBar);
                    recipe.AddIngredient(ItemID.TinBar, 15);
                    recipe.AddIngredient(ItemID.Topaz, 1);
                }
                if (recipe.HasResult(ItemID.TinChainmail))
                {
                    recipe.RemoveIngredient(ItemID.TinBar);
                    recipe.AddIngredient(ItemID.TinBar, 20);
                    recipe.AddIngredient(ItemID.Topaz, 1);
                }
            }
        }

        // Chest Loot
        public override void PostWorldGen()
        {
            for (int i = 0; i < 1000; i++)
            {
                int itemID = ItemID.Amethyst;
                if (Main.rand.NextBool(2)) itemID = ItemID.Topaz;

                Chest recipe = Main.chest[i];
                if (recipe == null || Main.tile[recipe.x, recipe.y].TileType != 21 || Main.tile[recipe.x, recipe.y].TileFrameX != 0)
                {
                    continue;
                }
                for (int j = 0; j < 40; j++)
                {
                    if (recipe.item[j].type == ItemID.None)
                    {
                        recipe.item[j].SetDefaults(itemID, false);
                        recipe.item[j].stack = Main.rand.Next(2, 5);
                        break;
                    }
                }
                if (i >= 999) break;
            }
        }
    }
}
