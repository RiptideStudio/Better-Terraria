/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file BandOfStarpower.cs
///
/// @details Modifies Band of Starpower

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using BetterTerraria.Common;

namespace BetterTerraria
{
    public class BandOfStarpower : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BandofStarpower)
            {
                item.rare = ItemRarityID.Green;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Band of starpower and regen
            if (item.type == ItemID.BandofStarpower)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Increases maximum mana by 40\n5% Increased magic critical strike chance");
                tooltips.Insert(tooltips.Count - 2, line);
                tooltips.RemoveAt(tooltips.Count - 1);
            }
        }

        public override void AddRecipes()
        {
            Recipe starBand = Recipe.Create(ItemID.BandofStarpower, 1);
            starBand.AddIngredient(ItemID.ManaCrystal, 3);
            starBand.AddRecipeGroup(BarNames.AnySilverBar, 5);
            starBand.Register();
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.BandofStarpower)
            {
                player.statManaMax2 += 20;
                player.GetCritChance(DamageClass.Magic) += 0.05f;
            }
        }
    }
}