/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file TungstenGear.cs
///
/// @details Description

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class TungstenGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TungstenShortsword)
            {
                item.damage = 15;
            }
        }
    }
}