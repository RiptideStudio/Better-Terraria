/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ThrowingKnifeRecipe.cs
///
/// @details Adds Recipe for Throwing Knife

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTerraria.Recipes
{
    public class ThrowingKnifeRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe throwingKnife = Recipe.Create(ItemID.ThrowingKnife, 5);
            throwingKnife.AddIngredient(ItemID.StoneBlock, 1);
            throwingKnife.AddRecipeGroup(RecipeGroupID.Wood, 1);
            throwingKnife.Register();
        }
    }
}