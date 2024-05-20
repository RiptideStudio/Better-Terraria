/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file TinGear.cs
///
/// @details Changes vanilla tin gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class TinGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TinShortsword)
            {
                item.damage = 10;
            }
            if (item.type == ItemID.TinBroadsword)
            {
                item.damage = 13;
            }
            if (item.type == ItemID.TinBow)
            {
                item.damage = 9;
            }

            if (item.type == ItemID.TopazStaff)
            {
                item.damage = 18;
            }
        }
    }
}