using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace TMMC.Tiles.Furniture
{
    public class TMMCBed : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.HasOutlines[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(200, 200, 200), name);

            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Beds };
            bed = true;
        }

        public override bool HasSmartInteract() => true;

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 64, 32, ItemType<Items.Placeables.Furniture.TMMCBed>());
        }

        public override bool NewRightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            int spawnX = i - tile.frameX / 18;
            int spawnY = j + 2;
            spawnX += tile.frameX >= 72 ? 5 : 2;
            if (tile.frameY % 38 != 0)
            {
                spawnY--;
            }
            player.FindSpawn();
            if(player.SpawnX == spawnX && player.SpawnY == spawnY)
            {
                player.RemoveSpawn();
                Main.NewText("Spawn Point removed!", 255, 240, 20, false);
            } else if(Player.CheckSpawn(spawnX, spawnY))
            {
                player.ChangeSpawn(spawnX, spawnY);
                Main.NewText("Spawn point set!", 255, 240, 20, false);
            }
            return true;
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = ItemType<Items.Placeables.Furniture.TMMCBed>();
        }
    }
}
