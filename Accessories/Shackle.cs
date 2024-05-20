/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Shackle.cs
///
/// @details Changes the shackle

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class Shackle : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Shackle)
            {
                item.defense = 3;
            }
        }

        public override void AddRecipes()
        {
            Recipe shackle = Recipe.Create(ItemID.Shackle, 1);
            shackle.AddRecipeGroup(RecipeGroupID.IronBar, 5);
            shackle.AddIngredient(ItemID.Chain, 20);
            shackle.Register();
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Shackle
            if (item.type == ItemID.Shackle)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Reduces damage taken by 5%");
                tooltips.Insert(tooltips.Count - 1, line);
            }
        }
        
        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.Shackle)
            {
                item.rare = ItemRarityID.Green;
                player.endurance += 0.05f;
            }
        }
    }
}