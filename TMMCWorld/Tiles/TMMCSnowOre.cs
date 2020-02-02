using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace TMMCWorld.Tiles
{
    public class TMMCSnowOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMerge[Type][TileID.SnowBlock] = true;
            Main.tileMerge[TileID.SnowBlock][Type] = true;

            drop = mod.ItemType("TMMCSnowOre");
            AddMapEntry(new Color(250, 150, 200));
        }
    }
}
