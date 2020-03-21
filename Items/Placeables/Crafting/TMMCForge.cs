using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Items.Placeables.Crafting
{
    public class TMMCForge : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Furnace);
            item.createTile = TileType<Tiles.Crafting.TMMCForge>();
        }
    }
}
