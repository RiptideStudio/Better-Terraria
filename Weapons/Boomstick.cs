/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Boomstick.cs
///
/// @details Modifies boomstick

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class Boomstick : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Boomstick)
            {
                item.damage = 15;
                item.useAnimation = 55;
                item.useTime = 55;
            }
        }
    }
}