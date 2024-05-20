/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file CopperGear.cs
///
/// @details Changes vanilla copper gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class CopperGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.CopperShortsword)
            {
                item.damage = 8;
            }

            if (item.type == ItemID.CopperBroadsword)
            {
                item.damage = 12;
                item.Size = new Vector2(1.25f, 1.25f);
            }

            if (item.type == ItemID.CopperBow)
            {
                item.damage = 8;
            }

            if (item.type == ItemID.CopperPickaxe)
            {
                item.tileBoost = 0;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.CopperChainmail)
            {
                player.GetCritChance(DamageClass.Melee) += 0.03f;
            }
        }

        /// <summary>
        /// Applies the copper armor setbonus
        /// </summary>
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            // Copper set bonus
            if (player.GetModPlayer<GlobalPlayer>().copperArmor)
            {
                if (item.type == ItemID.CopperBroadsword
                || item.type == ItemID.CopperBow
                || item.type == ItemID.CopperPickaxe
                || item.type == ItemID.CopperShortsword
                || item.type == ItemID.CopperAxe
                || item.type == ItemID.CopperHammer
                || item.type == ItemID.AmethystStaff)
                {
                    damage.Flat += (int)(item.OriginalDamage / 2);
                }
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.CopperChainmail)
            {
                TooltipLine line = new TooltipLine(Mod, "CritChance", "3% Increased melee critical strike chance");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.CopperChainmail && legs.type == ItemID.CopperGreaves && head.type == ItemID.CopperHelmet)
            {
                return "Copper Armor";
            }
            return "";
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Copper Armor")
            {
                player.setBonus = "2 defense\nCopper weapons deal 50% increased damage";
                player.GetModPlayer<GlobalPlayer>().copperArmor = true;
            }
        }
    }
}