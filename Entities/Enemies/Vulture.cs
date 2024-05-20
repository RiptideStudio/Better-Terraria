/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Vulture.cs
///
/// @details Modifies the Vulture's properties

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using Terraria.Audio;
using BetterTerraria.Accessories;

namespace BetterTerraria.Entities.Enemies
{
    public class Vulture : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (npc.type == NPCID.Vulture)
            {
                if (Main.rand.NextBool(2)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.Feather);
                if (Main.rand.NextBool(100)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ModContent.ItemType<BigFeather>());
            }
        }
    }
}