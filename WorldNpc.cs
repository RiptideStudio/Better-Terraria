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

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.lifeRegen == 0) npc.lifeRegen = 2;
        }

        // Loot drops
        public override void OnKill(NPC npc)
        {
            // Vultures
            if (npc.type == NPCID.Vulture)
            {
              if (Main.rand.NextBool(2)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.Feather);
              if (Main.rand.NextBool(100)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ModContent.ItemType<BigFeather>());
            }
            // Antlion Fliers
            if (npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.NextBool(3)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.Feather);
            }
            // Flying fish
            if (npc.type == NPCID.FlyingFish)
            {
                if (Main.rand.NextBool(3)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.Feather);
            }
            // Death eaters
            if (npc.type == NPCID.EaterofSouls || npc.type == NPCID.FaceMonster)
            {
                if (Main.rand.NextBool(2)) Item.NewItem(npc.GetSource_Death(), npc.position, npc.width, npc.height, ItemID.WormTooth,Main.rand.Next(1,2));
            }
        }

        public static int timer = 0;

        // AI
        public override void PostAI(NPC npc)
        {
            if (npc.type == NPCID.EyeofCthulhu)
            {
                timer++;
                if (npc.life > npc.lifeMax/1.5f)
                {
                    if (timer % 120 == 0 && npc.ai[3] <= 0)
                    {
                        timer = 0;
                        int newNpc = NPC.NewNPC(NPC.GetSource_NaturalSpawn(), (int)npc.position.X, (int)npc.position.Y, NPCID.DemonEye);
                        Main.npc[newNpc].rotation = npc.rotation;
                    }
                }
            }
        }

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
