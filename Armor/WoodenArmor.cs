/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file WoodenArmor.cs
///
/// @details Changes vanilla wooden

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class WoodenArmor : GlobalItem
    {
        public override void SetDefaults (Item item)
        {
            if (item.type == ItemID.WoodHelmet)
            {
                item.defense = 1;
            }
            if (item.type == ItemID.WoodBreastplate)
            {
                item.defense = 2;
            }
            if (item.type == ItemID.WoodGreaves)
            {
                item.defense = 1;
            }
        }
    }
}