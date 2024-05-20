/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ManaRegenerationBand.cs
///
/// @details Modifies Mana Regeneration Band

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class ManaRegenerationBand : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ManaRegenerationBand)
            {
                item.rare = ItemRarityID.Orange;
            }
        }
    }
}