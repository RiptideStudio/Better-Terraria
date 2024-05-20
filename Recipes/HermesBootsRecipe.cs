/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file HermesBootsRecipe.cs
///
/// @details Adds Recipe for Hermes Boots

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Recipes
{
    public class HermesBootsRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe hermesRecipe = Recipe.Create(ItemID.HermesBoots, 1);
            hermesRecipe.AddIngredient(ItemID.Silk, 10);
            hermesRecipe.AddIngredient(ItemID.Feather, 5);
            hermesRecipe.AddIngredient(ItemID.SwiftnessPotion, 1);
            hermesRecipe.Register();
        }
    }
}