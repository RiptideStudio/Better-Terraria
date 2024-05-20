/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file RubberBullet.cs
///
/// @details Adds a rubber bullet for early gunslinging
/// This bounces off walls, but has light damage 

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using Terraria.Audio;

namespace BetterTerraria
{
    public class RubberBulletProjectile : ModProjectile
    {
        private int bounce = 0;
        private int maxBounces = 5;

        /// <summary>
        /// Define the defaults of the rubber bullet
        /// </summary>
        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.width = 4;
            Projectile.height = 20;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 400;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
            Projectile.scale = 0.7f;
            Projectile.extraUpdates = 1;
        }

        /// @function AI()
        /// @details Add lighting and remove gravity
        public override void AI()
        {
            Projectile.aiStyle = 0;
            Lighting.AddLight(Projectile.position, 0.2f, 0.2f, 0.6f);
            Lighting.Brightness(1, 1);
        }

        /// @function Kill()
        /// @details Plays a sound and creates particles
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Dig.WithVolumeScale(0.5f).WithPitchOffset(0.8f), Projectile.position);
            for (var i = 0; i < 6; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
            }
        }

        /// @function OnHitNPC()
        /// @details Plays a sound when striking an NPC
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            SoundEngine.PlaySound(SoundID.Item10, new Vector2(Projectile.position.X, Projectile.position.Y));
        }


        /// @function OnTileCollide()
        /// @details Bounces off of tiles
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            bounce++;
            SoundEngine.PlaySound(SoundID.Dig.WithVolumeScale(0.5f).WithPitchOffset(0.8f), Projectile.position);
            for (var i = 0; i < 4; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
            }
            if (Projectile.velocity.X != oldVelocity.X) Projectile.velocity.X = -oldVelocity.X;
            if (Projectile.velocity.Y != oldVelocity.Y) Projectile.velocity.Y = -oldVelocity.Y;
            Projectile.aiStyle = 1;

            if (bounce >= maxBounces) return true;
            else return false;
        }
    }
}