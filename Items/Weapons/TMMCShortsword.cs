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
    public class TMMCShortsword : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(38);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 22);

            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 17;
            item.knockBack = 1.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 1);
            recipe.AddRecipeGroup("IronBar", 7); // Uses either Iron or Lead Bars
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
