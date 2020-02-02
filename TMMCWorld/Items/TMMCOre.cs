using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace TMMCWorld.Items
{
    public class TMMCOre : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.autoReuse = true;
            item.useTurn = true;
            item.useStyle = 1;
            item.useAnimation = 8;
            item.useTime = 8;
            item.consumable = true;
            item.maxStack = 999;
            item.createTile = mod.TileType("TMMCOre");
        }
    }
}
