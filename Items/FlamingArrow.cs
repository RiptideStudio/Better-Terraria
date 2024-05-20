/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file FlamingArrow.cs
///
/// @details Modifies flaming arrow

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class FlamingArrow : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.FragmentNebula)
            {
                item.damage = 7;
            }
        }
    }
}