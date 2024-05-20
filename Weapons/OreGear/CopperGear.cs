/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file CopperGear.cs
///
/// @details Changes vanilla copper gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class CopperGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.CopperShortsword)
            {
                item.damage = 8;
            }

            if (item.type == ItemID.CopperBroadsword)
            {
                item.damage = 12;
                item.Size = new Vector2(1.25f, 1.25f);
            }

            if (item.type == ItemID.CopperBow)
            {
                item.damage = 8;
            }

            if (item.type == ItemID.CopperPickaxe)
            {
                item.tileBoost = 0;
            }
        }
    }
}