using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Armours
{
    [AutoloadEquip(EquipType.Head)]
    public class TMMCArmourHelmet : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 14;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 20);
            recipe.AddIngredient(ItemType<TMMCBasicItem>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TMMCArmourChestplate>() && legs.type == ItemType<TMMCArmourGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.meleeDamage += 0.4f;
            player.moveSpeed += 0.4f;
        }
    }
}
