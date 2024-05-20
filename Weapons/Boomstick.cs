/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Boomstick.cs
///
/// @details Modifies boomstick

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
    public class Boomstick : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Boomstick)
            {
                item.damage = 15;
                item.useAnimation = 55;
                item.useTime = 55;
            }
        }
        public override void AddRecipes()
        {
            Recipe boomStick = Recipe.Create(ItemID.Boomstick, 1);
            boomStick.AddIngredient(ModContent.ItemType<LegalGunParts>(), 1);
            boomStick.AddIngredient(ItemID.Vine, 3);
            boomStick.AddIngredient(ItemID.JungleSpores, 7);
            boomStick.AddRecipeGroup(RecipeGroupID.IronBar, 10);
            boomStick.AddIngredient(ItemID.RichMahogany, 25);
            boomStick.Register();
        }
    }
}