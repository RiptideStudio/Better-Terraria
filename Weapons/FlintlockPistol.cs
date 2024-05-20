/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file FlintlockPistol.cs
///
/// @details Modifies flintlock pistol

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using BetterTerraria.Materials;

namespace BetterTerraria.Weapons
{
    public class FlintlockPistol : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.FlintlockPistol)
            {
                item.damage = 10;
                item.autoReuse = true;
            }
        }

        public override void AddRecipes()
        {
            Recipe pistol = Recipe.Create(ItemID.FlintlockPistol, 1);
            pistol.AddIngredient(ModContent.ItemType<LegalGunParts>(), 1);
            pistol.AddRecipeGroup(RecipeGroupID.IronBar, 10);
            pistol.AddRecipeGroup(RecipeGroupID.Wood, 25);
            pistol.Register();
        }
    }
}