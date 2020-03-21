using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Placeables.Furniture
{
    public class TMMCBed : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Bed);
            item.createTile = TileType<Tiles.Furniture.TMMCBed>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.TMMCBasicItem>(), 15);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
