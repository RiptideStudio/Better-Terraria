/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file GoldGear.cs
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
    public class GoldGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.GoldShortsword)
            {
                item.damage = 16;
            }
        }
    }
}