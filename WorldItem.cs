/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file WorldItem.cs
///
/// @details Implements base global item class

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using BetterTerraria;
using System.Collections.Generic;

namespace BetterTerraria
{
    public class WorldItem : GlobalItem
    {
        public override void HoldStyle(Item item, Player player, Rectangle heldItemFrame)
        {
            if (item.type == ItemID.Boomstick)
            {
                Vector2 cursorPos = Main.MouseWorld;
                float cursorDirection = cursorPos.AngleTo(player.position);

                item.holdStyle = ItemHoldStyleID.HoldHeavy;
                player.itemLocation.Y = player.Center.Y-item.height/2;
            }
        }

        // Update armor and accessories 
        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.CopperChainmail)
            {
                player.GetCritChance(DamageClass.Melee) += 0.03f;
            }
            if (item.type == ItemID.TinGreaves)
            {
                player.moveSpeed += 0.05f;
            }
            // Wooden armor
            if (item.type == ItemID.WoodHelmet || item.type == ItemID.WoodBreastplate || item.type == ItemID.WoodGreaves)
            {
                player.moveSpeed -= 0.05f;
            }
            // Iron armor
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
            // Lead armor
            if (item.type == ItemID.LeadHelmet)
            {
                player.GetCritChance(DamageClass.Generic) += 3;
            }
            if (item.type == ItemID.LeadGreaves)
            {
                player.moveSpeed += 0.07f;
            }
            // Shackle
            if (item.type == ItemID.Shackle)
            {
                item.rare = ItemRarityID.Green;
                player.endurance += 0.05f;
            }
            // Band of starpower and regen
            if (item.type == ItemID.BandofStarpower)
            {
                player.statManaMax2 += 20;
                player.GetCritChance(DamageClass.Magic) += 0.05f;
            }
            if (item.type == ItemID.BandofRegeneration)
            {
                player.statLifeMax2 += 20;
                player.lifeRegen += 1;
            }
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

        // Damage updates
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
                    damage.Flat = (int)(item.OriginalDamage/2);
                }
            }
        }

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

        // Get armor set bonus data
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.CopperChainmail && legs.type == ItemID.CopperGreaves && head.type == ItemID.CopperHelmet)
            {
                return "Copper Armor";
            }
            if (body.type == ItemID.TinChainmail && legs.type == ItemID.TinGreaves && head.type == ItemID.TinHelmet)
            {
                return "Tin Armor";
            }
            if (body.type == ItemID.WoodBreastplate && legs.type == ItemID.WoodGreaves && head.type == ItemID.WoodHelmet)
            {
                return "Wood Armor";
            }
            if (body.type == ItemID.IronChainmail && legs.type == ItemID.IronGreaves && head.type == ItemID.IronHelmet)
            {
                return "Iron Armor";
            }
            if (body.type == ItemID.LeadChainmail && legs.type == ItemID.LeadGreaves && head.type == ItemID.LeadHelmet)
            {
                return "Lead Armor";
            }
            if (body.type == ItemID.SilverChainmail && legs.type == ItemID.SilverGreaves && head.type == ItemID.SilverHelmet)
            {
                return "Silver Armor";
            }
            if (body.type == ItemID.TungstenChainmail && legs.type == ItemID.TungstenGreaves && head.type == ItemID.TungstenHelmet)
            {
                return "Tungsten Armor";
            }
            return "";
        }

        // Tooltips
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Copper armor
            if (item.type == ItemID.CopperChainmail)
            {
                TooltipLine line = new TooltipLine(Mod, "CritChance", "3% Increased melee critical strike chance");
                tooltips.Insert(tooltips.Capacity-1, line);
            }
            // Tin armor
            if (item.type == ItemID.TinGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "5% Increased movement speed");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
            // Wood armor
            if (item.type == ItemID.WoodHelmet || item.type == ItemID.WoodBreastplate || item.type == ItemID.WoodGreaves)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "5% Decreased movement speed");
                tooltips.Insert(tooltips.Capacity - 1, line);
            }
            // Iron armor
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
            // Shackle
            if (item.type == ItemID.Shackle)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Reduces damage taken by 5%");
                tooltips.Insert(tooltips.Count-1, line);
            }
            // Band of starpower and regen
            if (item.type == ItemID.BandofStarpower)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Increases maximum mana by 40\n5% Increased magic critical strike chance");
                tooltips.Insert(tooltips.Count - 2, line);
                tooltips.RemoveAt(tooltips.Count - 1);
            }
            if (item.type == ItemID.BandofRegeneration)
            {
                TooltipLine line = new TooltipLine(Mod, "Movement", "Increases maximum life by 20\nRegenerates life");
                tooltips.Insert(tooltips.Count-2, line);
                tooltips.RemoveAt(tooltips.Count-1);
            }
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

        // Apply armor set bonuses
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "Copper Armor")
            {
                player.setBonus = "2 defense\nCopper weapons deal 50% increased damage";
                player.GetModPlayer<GlobalPlayer>().copperArmor = true;
            }
            if (set == "Tin Armor")
            {
                player.setBonus = "3 defense\nTin weapons attack 33% faster";
                player.GetModPlayer<GlobalPlayer>().tinArmor = true;
                player.statDefense += 1;
            }
            if (set == "Wood Armor")
            {
                player.setBonus = "1 defense\nReduces knockback";
                player.GetModPlayer<GlobalPlayer>().woodArmor = true;
            }
            if (set == "Iron Armor")
            {
                player.setBonus = "2 defense\nReduces damage taken by 10%\n10% Decreased movement speed";
                player.moveSpeed -= 0.1f;
                player.GetModPlayer<GlobalPlayer>().woodArmor = true;
            }
            if (set == "Lead Armor")
            {
                player.setBonus = "6 defense";
                player.statDefense += 3;
            }
        }
    }
}
