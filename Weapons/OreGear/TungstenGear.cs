/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file TungstenGear.cs
///
/// @details Description

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class TungstenGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TungstenShortsword)
            {
                item.damage = 15;
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.TungstenChainmail && legs.type == ItemID.TungstenGreaves && head.type == ItemID.TungstenHelmet)
            {
                return "Tungsten Armor";
            }
            return "";
        }
    }
}