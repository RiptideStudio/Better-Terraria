/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file CactusSword.cs
///
/// @details Modifies Cactus Sword

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class CactusSword : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item == ItemID.CactusSword)
            {
                item.damage = 13;
                item.scale = 1.25f;
                item.knockBack = 7;
            }
        }
    }
}