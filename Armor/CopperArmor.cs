/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file CopperArmor.cs
///
/// @details Changes vanilla copper armor

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class CopperArmor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.CopperHelmet)
            {
                item.defense = 2;
                item.rare = ItemRarityID.Blue;
            }

            if (item.type == ItemID.CopperChainmail)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Blue;
            }

            if (item.type == ItemID.CopperGreaves)
            {
                item.defense = 2;
                item.rare = ItemRarityID.Blue;
            }
        }
    }
}

