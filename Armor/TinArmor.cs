/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file TinArmor.cs
///
/// @details Changes vanilla tin armor

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class TinArmor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TinHelmet)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Blue;
            }
            if (item.type == ItemID.TinChainmail)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Blue;
            }
            if (item.type == ItemID.TinGreaves)
            {
                item.defense = 2;
                item.rare = ItemRarityID.Blue;
            }
        }
    }
}