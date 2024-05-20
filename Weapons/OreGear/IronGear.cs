/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file IronGear.cs
///
/// @details Changes vanilla iron gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class IronGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.IronShortsword)
            {
                item.damage = 12;
            }
            if (item.type == ItemID.IronBroadsword)
            {
                item.scale = 1.2f;
                item.damage = 15;
            }
            if (item.type == ItemID.IronBow)
            {
                item.damage = 10;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.IronHelmet)
            {
                player.GetDamage(DamageClass.Generic).Flat += 1;
            }
            if (item.type == ItemID.IronChainmail)
            {
                player.GetModPlayer<GlobalPlayer>().woodArmor = true;
            }
            if (item.type == ItemID.IronGreaves)
            {
                player.maxFallSpeed += 5;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.IronHelmet)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "+1 damage");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
            if (item.type == ItemID.IronChainmail)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Reduces knockback taken");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
            if (item.type == ItemID.IronGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "You fall faster");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Iron Armor")
            {
                player.setBonus = "2 defense\nReduces damage taken by 10%\n10% Decreased movement speed";
                player.moveSpeed -= 0.1f;
                player.GetModPlayer<GlobalPlayer>().woodArmor = true;
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.IronChainmail && legs.type == ItemID.IronGreaves && head.type == ItemID.IronHelmet)
            {
                return "Iron Armor";
            }
            return "";
        }
    }
}