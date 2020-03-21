using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Tiles
{
    public class TMMCOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            drop = ItemType<Items.Placeables.TMMCOre>();

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(98, 36, 97), name);

            minPick = 60;
        }
    }
}
