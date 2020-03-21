using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Placeables.Furniture
{
    public class TMMCChest : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Chest);
            item.createTile = TileType<Tiles.Furniture.TMMCChest>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.TMMCBasicItem>(), 8);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
