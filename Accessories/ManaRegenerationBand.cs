/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ManaRegenerationBand.cs
///
/// @details Modifies Mana Regeneration Band

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class ManaRegenerationBand : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ManaRegenerationBand)
            {
                item.rare = ItemRarityID.Orange;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.ManaRegenerationBand)
            {
                TooltipLine Name = new TooltipLine(Mod, "CelestialBand", "Celestial Band");
                Name.OverrideColor = Color.LightSalmon;
                TooltipLine line = new TooltipLine(Mod, "Movement", "7% Increased magic critical strike chance\nRegenerates health and mana\nIncreases maximum health by 20");
                tooltips.Insert(tooltips.Count - 2, line);
                tooltips.RemoveAt(tooltips.Count - 1);
                tooltips.RemoveAt(0);
                tooltips.Insert(0, Name);
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.ManaRegenerationBand)
            {
                player.statLifeMax2 += 20;
                //player.statManaMax2 += 20;
                player.lifeRegen += 1;
                player.lifeRegenTime += 5;
                player.manaRegen += 1;
                player.GetCritChance(DamageClass.Magic) += 0.07f;
            }
        }
    }
}