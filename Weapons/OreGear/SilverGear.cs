/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file SilverGear.cs
///
/// @details Changes vanilla silver gear

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons.OreGear
{
    public class SilverGear : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.SilverShortsword)
            {
                item.damage = 14;
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (body.type == ItemID.SilverChainmail && legs.type == ItemID.SilverGreaves && head.type == ItemID.SilverHelmet)
            {
                return "Silver Armor";
            }
            return "";
        }
    }
}