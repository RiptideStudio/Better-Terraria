/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ShurikenRecipe.cs
///
/// @details Adds Recipe for Shuriken

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Recipes
{
    public class ShurikenRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe shurkien = Recipe.Create(ItemID.Shuriken, 10);
            shurkien.AddIngredient(ItemID.Cactus, 1);
            shurkien.AddIngredient(ItemID.StoneBlock, 1);
            shurkien.Register();
        }
    }
}