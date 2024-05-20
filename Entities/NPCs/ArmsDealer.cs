/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file ArmsDealer.cs
///
/// @details Modifies the Arms Dealer's shop

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using Terraria.Audio;

namespace BetterTerraria.Entities.NPCs
{
    public class ArmsDealer : GlobalNPC
    {
        /// <summary>
        /// Removes the flintlock pistol and adds legal gun parts instead
        /// </summary>
        public override void ModifyShop(NPCShop shop)
        {
            // Arms dealer shop
            if (shop.NpcType == NPCID.ArmsDealer)
            {
                shop.GetEntry(ItemID.FlintlockPistol).Disable();
                shop.Add(Mod.Find<ModItem>("LegalGunParts").Type);
            }
        }
    }
}