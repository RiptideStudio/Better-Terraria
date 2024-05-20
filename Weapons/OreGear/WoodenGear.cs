/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file WoodenGear.cs
///
/// @details Changes vanilla wooden gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class WoodenGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.WoodenSword)
            {
                item.damage = 5;
                item.rare = ItemRarityID.Gray;
            }

            if (item.type == ItemID.WoodenSword)
            {
                item.damage = 5;
                item.rare = ItemRarityID.Gray;
            }
        }
    }
}