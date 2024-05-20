/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file TinGear.cs
///
/// @details Changes vanilla tin gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class TinGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TinShortsword)
            {
                item.damage = 10;
            }
            if (item.type == ItemID.TinBroadsword)
            {
                item.damage = 13;
            }
            if (item.type == ItemID.TinBow)
            {
                item.damage = 9;
            }

            if (item.type == ItemID.TopazStaff)
            {
                item.damage = 18;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.TinGreaves)
            {
                player.moveSpeed += 0.05f;
            }
        }

        /// <summary>
        /// Make tin items faster as the setbonus
        /// </summary>
        public override void UseItemFrame(Item item, Player player)
        {
            // Tin set bonus
            if (player.GetModPlayer<GlobalPlayer>().tinArmor)
            {
                if (item.type == ItemID.TinBroadsword
                || item.type == ItemID.TinBow
                || item.type == ItemID.TinPickaxe
                || item.type == ItemID.TinShortsword
                || item.type == ItemID.TinAxe
                || item.type == ItemID.TinHammer
                || item.type == ItemID.TopazStaff)
                {
                    if (player.ItemAnimationJustStarted)
                    {
                        int animationTime = (int)(item.useAnimation * 0.66f);
                        if (item.type == ItemID.TinPickaxe) animationTime -= 1;

                        player.pickSpeed -= (1 / animationTime);
                        player.itemAnimationMax = animationTime;
                        player.itemAnimation = animationTime;
                        player.itemTime = animationTime;
                        player.itemTimeMax = animationTime;
                    }
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.TinGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "5% Increased movement speed");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
        }

        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Tin Armor")
            {
                player.setBonus = "3 defense\nTin weapons attack 33% faster";
                player.GetModPlayer<GlobalPlayer>().tinArmor = true;
                player.statDefense += 1;
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.TinChainmail && legs.type == ItemID.TinGreaves && head.type == ItemID.TinHelmet)
            {
                return "Tin Armor";
            }
            return "";
        }
    }
}