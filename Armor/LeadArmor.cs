/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file LeadArmor.cs
///
/// @details Changes vanilla lead armor

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class LeadArmor : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.LeadHelmet)
            {
                item.defense = 4;
                item.rare = ItemRarityID.Green;
            }
            if (item.type == ItemID.LeadChainmail)
            {
                item.defense = 4;
                item.rare = ItemRarityID.Green;
            }
            if (item.type == ItemID.LeadGreaves)
            {
                item.defense = 3;
                item.rare = ItemRarityID.Green;
            }
        }
    }
}