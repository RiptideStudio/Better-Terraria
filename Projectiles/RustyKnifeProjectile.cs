using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using BetterTerraria;

namespace BetterTerraria.Projectiles
{
	public class RustyKnifeProjectile : ModProjectile
	{
        public override void SetDefaults()
        {
            Projectile.aiStyle = 1;
            Projectile.timeLeft = 600;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.width = 8;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.height = 14;
            Projectile.penetrate = 2;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
        }

        int dust_num = DustID.WoodFurniture;
        int dust_num2 = DustID.WoodFurniture;
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            //Give the item on tile hit
            if (Main.rand.Next(0, 3) == 1)
            {
                //Drop dagger on hit
                Item.NewItem(Projectile.GetSource_Death(), Projectile.getRect(), Mod.Find<ModItem>("RustyKnife").Type);
            }
            //If collide with tile
            for (var i = 0; i < 7; i++)
            {
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, dust_num2);
            }
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position); // Boing
            return true;
        }

        public override void AI()
        {
            Projectile.width = 8;
            Projectile.height = 14;
            //Right click to destroy enchanted gauntlet
            if (Projectile.aiStyle == 1) Projectile.aiStyle = 0;

            if (Projectile.timeLeft < 580)
            {
                if (Projectile.aiStyle == 0) Projectile.velocity.Y += 2;
                Projectile.velocity.X *= 0.97f;
                Projectile.aiStyle = 2;
                Projectile.velocity.Y += 0.125f;
            }
            Projectile.width = 14;
            Projectile.height = 14;
        }

        public override void Kill(int timeLeft)
        {
            Player p = Main.player[Projectile.owner];
            for (int i = 0; i < 6; i++)
            {
                int num372 = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, dust_num, 0f, 0f, 100, default(Color), Main.rand.NextFloat(0.75f,1.25f));
                Main.dust[num372].noGravity = true;
                Main.dust[num372].velocity *= 5f;
                num372 = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, dust_num2, 0f, 0f, 100, default(Color), Main.rand.NextFloat(0.75f, 1.25f));
                Main.dust[num372].velocity *= 1;
            }
        }
    }
}