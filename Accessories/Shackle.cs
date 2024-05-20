/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Shackle.cs
///
/// @details Changes the shackle

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class Shackle : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Shackle)
            {
                item.defense = 3;
            }
        }
    }
}