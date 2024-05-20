/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file BandOfStarpower.cs
///
/// @details Modifies Band of Starpower

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class BandOfStarpower : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BandofStarpower)
            {
                item.rare = ItemRarityID.Green;
            }
        }
    }
}