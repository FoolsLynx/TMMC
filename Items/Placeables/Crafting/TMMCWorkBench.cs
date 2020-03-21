using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Placeables.Crafting
{
    public class TMMCWorkBench : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(28, 14);
            item.value = Item.sellPrice(silver: 1, copper: 50);

            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.consumable = true;
            item.maxStack = 99;

            item.createTile = TileType<Tiles.Crafting.TMMCWorkBenches>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
