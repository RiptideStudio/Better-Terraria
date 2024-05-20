/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file WoodenGear.cs
///
/// @details Changes vanilla wooden gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class WoodenGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.WoodenSword)
            {
                item.damage = 5;
                item.rare = ItemRarityID.Gray;
            }

            if (item.type == ItemID.WoodenSword)
            {
                item.damage = 5;
                item.rare = ItemRarityID.Gray;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.WoodHelmet || item.type == ItemID.WoodBreastplate || item.type == ItemID.WoodGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "5% Decreased movement speed");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Wood Armor")
            {
                player.setBonus = "1 defense\nReduces knockback";
                player.GetModPlayer<GlobalPlayer>().woodArmor = true;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.WoodHelmet || item.type == ItemID.WoodBreastplate || item.type == ItemID.WoodGreaves)
            {
                player.moveSpeed -= 0.05f;
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.WoodBreastplate && legs.type == ItemID.WoodGreaves && head.type == ItemID.WoodHelmet)
            {
                return "Wood Armor";
            }
            return "";
        }
    }
}