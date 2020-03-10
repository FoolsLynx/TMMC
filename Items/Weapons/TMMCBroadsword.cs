using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Weapons
{
    public class TMMCBroadsword : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(38);
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(silver: 22);

            item.autoReuse = true;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 20;
            item.knockBack = 4.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 2);
            recipe.AddRecipeGroup("IronBar", 8); // Uses either Iron or Lead Bars
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
