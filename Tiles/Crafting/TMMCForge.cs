using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace TMMC.Tiles.Crafting
{
    public class TMMCForge : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLighted[Type] = true;
            

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Origin = new Point16(1, 1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(191, 142, 111), name);

            disableSmartCursor = true;

            adjTiles = new int[] { TileID.Furnaces };
            animationFrameHeight = 38;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 48, 32, ItemType<Items.Placeables.Crafting.TMMCForge>());
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.04f;
            g = 0.95f;
            b = 1f;
        }

        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            if(++frameCounter >= 5)
            {
                frameCounter = 0;
                
                if(++frame >= 12)
                {
                    frame = 0;
                }
            }
        }
        
    }
}
