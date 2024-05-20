/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file IronGear.cs
///
/// @details Changes vanilla iron gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class IronGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.IronShortsword)
            {
                item.damage = 12;
            }
            if (item.type == ItemID.IronBroadsword)
            {
                item.scale = 1.2f;
                item.damage = 15;
            }
            if (item.type == ItemID.IronBow)
            {
                item.damage = 10;
            }
        }
    }
}