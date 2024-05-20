/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file BandOfRegeneration.cs
///
/// @details Modifies Band of Regeneration

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
    public class BandOfRegeneration : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BandofRegeneration)
            {
                item.rare = ItemRarityID.Green;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.BandofRegeneration)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Increases maximum life by 20\nRegenerates life");
                tooltips.Insert(tooltips.Count - 2, line);
                tooltips.RemoveAt(tooltips.Count - 1);
            }
        }

        public override void AddRecipes()
        {
            Recipe regenBand = Recipe.Create(ItemID.BandofRegeneration, 1);
            regenBand.AddIngredient(ItemID.LifeCrystal, 1);
            regenBand.AddRecipeGroup(BarNames.AnyGoldBar, 5);
            regenBand.Register();
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.BandofRegeneration)
            {
                player.statLifeMax2 += 20;
                player.lifeRegen += 1;
            }
        }
    }
}