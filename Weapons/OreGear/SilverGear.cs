/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file SilverGear.cs
///
/// @details Changes vanilla silver gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class SilverGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.SilverShortsword)
            {
                item.damage = 14;
            }
        }
    }
}