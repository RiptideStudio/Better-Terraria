/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file LeadGear.cs
///
/// @details Changes vanilla lead gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class LeadGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.LeadShortsword)
            {
                item.damage = 13;
            }
            if (item.type == ItemID.LeadBroadsword)
            {
                item.damage = 16;
                item.scale = 1.2f;
            }
            if (item.type == ItemID.LeadBow)
            {
                item.damage = 11;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.LeadHelmet)
            {
                player.GetCritChance(DamageClass.Generic) += 3;
            }
            if (item.type == ItemID.LeadGreaves)
            {
                player.moveSpeed += 0.07f;
            }
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Lead Armor")
            {
                player.setBonus = "6 defense";
                player.statDefense += 3;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Lead armor
            if (item.type == ItemID.LeadHelmet)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "3% Increased critical strike chance");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
            if (item.type == ItemID.LeadGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "7% Increased movement speed");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.LeadChainmail && legs.type == ItemID.LeadGreaves && head.type == ItemID.LeadHelmet)
            {
                return "Lead Armor";
            }
            return "";
        }
    }
}