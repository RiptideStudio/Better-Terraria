/// @mod Better Terraria
///
/// @author RiptideDev
///
/// @file RubberBullet.cs
///
/// @details Adds a rubber bullet ammo into the game
/// This has no damage, but can be obtained early

using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using BetterTerraria;
using Terraria.Audio;

namespace BetterTerraria.Items
{
    public class RubberBullet : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 1;
            Item.value = 25;
            Item.rare = ItemRarityID.Blue;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<Projectiles.RubberBulletProjectile>();
            Item.ammo = AmmoID.Bullet;
            Item.maxStack = 9999;
            Item.shootSpeed = 4.5f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(25);
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}