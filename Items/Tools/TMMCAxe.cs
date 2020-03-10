using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Tools
{
    public class TMMCAxe : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(silver: 24);

            item.autoReuse = true;
            item.useTime = 17;
            item.useAnimation = 25;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 14;
            item.knockBack = 3.25f;

            item.axe = 13; // Slightly better than a platinum axe
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 2);
            recipe.AddRecipeGroup("Wood", 3);
            recipe.AddRecipeGroup("IronBar", 9); // Uses either Iron or Lead Bars
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
