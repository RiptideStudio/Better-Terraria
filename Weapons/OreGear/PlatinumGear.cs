/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file PlatinumGear.cs
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
    public class PlatinumGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.PlatinumShortsword)
            {
                item.damage = 18;
            }
        }
    }
}