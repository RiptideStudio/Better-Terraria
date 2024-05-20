/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ZombieArm.cs
///
/// @details Modifies Zombie Arm

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;

namespace BetterTerraria.Weapons
{
    public class ZombieArm : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ZombieArm)
            {
                item.damage = 16;
                item.useAnimation = 15;
                item.useTime = 15;
            }
        }
    }
}