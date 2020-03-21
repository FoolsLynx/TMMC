using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Tools
{
    public class TMMCDrill : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(20, 12);
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.value = Item.sellPrice(silver: 50);

            item.autoReuse = true;
            item.useTime = 8;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item23;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.damage = 14;
            item.knockBack = 6f;
            item.shoot = ProjectileType<Projectiles.Tools.TMMCDrill>();
            item.shootSpeed = 40f;

            item.pick = 100;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
