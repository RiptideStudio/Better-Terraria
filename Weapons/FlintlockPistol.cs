/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file FlintlockPistol.cs
///
/// @details Modifies flintlock pistol

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class FlintlockPistol : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.FlintlockPistol)
            {
                item.damage = 12;
                item.autoReuse = true;
            }
        }
    }
}