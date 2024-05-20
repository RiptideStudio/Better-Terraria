using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using BetterTerraria.Accessories;
using Terraria.ModLoader.IO;
using System.IO;

namespace BetterTerraria
{
    public class WorldNpc : GlobalNPC
    {

        /// <summary>
        /// All non-boss enemies have 25% more health and damage
        /// </summary>
        public override void SetDefaults(NPC entity)
        {
            // All enemies are stronger and drop more money
            if (!entity.boss && !entity.CountsAsACritter)
            {
                entity.lifeMax += (int)(entity.lifeMax * .25f); ;
                entity.value += (int)(entity.value * .25f); ;
                entity.damage += (int)(entity.damage * .25f);
            }
            
            if (entity.boss)
            {
                entity.lifeMax += (int)(entity.lifeMax * 0.5f);
            }
        }

        /// <summary>
        /// Enemies slowly regenerate their life
        /// </summary>
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.lifeRegen == 0) npc.lifeRegen = 2;
        }
    }
}
