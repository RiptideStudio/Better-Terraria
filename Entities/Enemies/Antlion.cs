/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file Antlion.cs
///
/// @details Modifies the Antlion's properties

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
    public class Antlion : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.NextBool(3)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.Feather);
            }
        }
    }
}