/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file BandOfRegeneration.cs
///
/// @details Modifies Band of Regeneration

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class BandOfRegeneration : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BandofRegeneration)
            {
                item.rare = ItemRarityID.Green;
            }
        }
    }
}