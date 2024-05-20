/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file WoodenArrowRecipe.cs
///
/// @details Adds Recipe for Wooden Arrow

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Recipes
{
    public class WoodenArrowRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe arrow = Recipe.Create(ItemID.WoodenArrow, 100);
            arrow.AddIngredient(ItemID.StoneBlock, 1);
            arrow.AddRecipeGroup(RecipeGroupID.Wood, 1);
            arrow.AddIngredient(ItemID.Feather, 1);
            arrow.Register();
        }
    }
}