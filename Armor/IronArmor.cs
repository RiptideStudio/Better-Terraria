/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file IronArmor.cs
///
/// @details Changes vanilla iron armor

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class IronArmor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.IronHelmet)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Green;
            }
            if (item.type == ItemID.IronChainmail)
            {
                item.defense = 4;
                item.rare = ItemRarityID.Green;
            }
            if (item.type == ItemID.IronGreaves)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Green;
            }
        }
    }
}