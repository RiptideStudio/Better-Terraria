/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file FaceMonster.cs
///
/// @details Modifies the Face Monster's drops

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using Terraria.Audio;

namespace BetterTerraria.Entities.Enemies
{
    public class FaceMonster : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (npc.type == NPCID.FaceMonster)
            {
                if (Main.rand.NextBool(2)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.WormTooth, Main.rand.Next(1, 2));
            }
        }
    }
}