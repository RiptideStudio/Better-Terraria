/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file FrostburnArrow.cs
///
/// @details Modifies frostburn arrow

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class FrostburnArrow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.FrostburnArrow)
            {
                item.damage = 4;
            }
        }
    }
}