/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file LeadGear.cs
///
/// @details Changes vanilla lead gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria
{
    public class LeadGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.LeadShortsword)
            {
                item.damage = 13;
            }
            if (item.type == ItemID.LeadBroadsword)
            {
                item.damage = 16;
                item.scale = 1.2f;
            }
            if (item.type == ItemID.LeadBow)
            {
                item.damage = 11;
            }
        }
    }
}