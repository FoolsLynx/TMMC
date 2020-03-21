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
    public class TMMCClock : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GrandfatherClock);
            item.createTile = TileType<Tiles.Furniture.TMMCClock>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemType<Items.TMMCBasicItem>(), 10);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
