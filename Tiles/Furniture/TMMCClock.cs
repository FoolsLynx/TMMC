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
    public class TMMCClock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16, 16 };
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(200, 200, 200), name);
            adjTiles = new int[] { TileID.GrandfatherClocks };
        }


        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 48, 72, ItemType<Items.Placeables.Furniture.TMMCClock>());
        }

        public override bool NewRightClick(int i, int j)
        {
			string text = "AM";
			double time = Main.time;
			if (!Main.dayTime)
			{
				time += 54000.0;
			}
			time = time / 86400.0 * 24.0;
			time = time - 7.5 - 12.0;
			if (time < 0.0)
			{
				time += 24.0;
			}
			if (time >= 12.0)
			{
				text = "PM";
			}

			int intTime = (int)time;
			
			double deltaTime = time - intTime;
			deltaTime = (int)(deltaTime * 60.0);
			
			string text2 = string.Concat(deltaTime);
			if (deltaTime < 10.0)
			{
				text2 = "0" + text2;
			}
			if (intTime > 12)
			{
				intTime -= 12;
			}
			if (intTime == 0)
			{
				intTime = 12;
			}
			
			var newText = string.Concat("Time: ", intTime, ":", text2, " ", text);
			Main.NewText(newText, 255, 240, 20);
			return true;
		}

		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (closer) Main.clock = true;
		}

	}
}
