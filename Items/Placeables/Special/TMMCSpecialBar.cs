using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Placeables.Special
{
    public class TMMCSpecialBar : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(16);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1);

            item.autoReuse = true;
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.consumable = true;
            item.maxStack = 99;

            item.createTile = TileType<Tiles.TMMCBars>();
            item.placeStyle = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<Items.TMMCBasicItem>(), 4);
            recipe.AddTile(TileType<Tiles.Crafting.TMMCForge>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
