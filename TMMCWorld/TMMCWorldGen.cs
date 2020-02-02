using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.GameContent.Generation;

namespace TMMCWorld
{
    public class TMMCWorldGen : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("TMMC Ore Generation", OreGeneration));
            }
        }


        private void OreGeneration(GenerationProgress progress)
        {
            // Message to show while code is running
            progress.Message = "Generating Modded Ores!";
            // 6E-05 = 0.00006
            // So (Main.maxTilesX * Main.maxTilesY) * 0.00006
            // (4200 * 1200) * 0.00006 = 302.4
            for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
            {
                // Random X Position
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                // Random Y Position
                // The min value is from top of the world and max is the bottom of the world
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);

                WorldGen.TileRunner(
                    x,  // X Pos
                    y,  // Y Pos
                    (double)WorldGen.genRand.Next(3, 6), // Strength (Mess around with this number until happy
                    WorldGen.genRand.Next(2, 6), // Steps (Again, mess around with this number until you are happy
                    mod.TileType("TMMCOre"), // The Ore type
                    false, // Add Tile? If true then this will make the tile appear anywhere air would appear
                    0f, // These should be set to 0f
                    0f, // These should be set to 0f
                    false, // These do not change on the Y value
                    true // This overrides any tile that already exists
                );

            }

            // If you want to ensure that the ore spawns you can do a count.
            int count = 0;
            // In this case, we check if there is a minimum of 1 ore spawned.
            while (count < 1)
            {
                // We can also spawn the tile in certain tiles
                for (var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
                {
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);
                    Tile tile = Framing.GetTileSafely(x, y);
                    if (tile.active() && (tile.type == TileID.SnowBlock || tile.type == TileID.IceBlock))
                    {
                        WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(2, 4), WorldGen.genRand.Next(3, 5), mod.TileType("TMMCSnowOre"));
                        count++;
                    }
                }
            }
        }

        public override void PostWorldGen()
        {
            // Add Items to Chests
            int itemToPlaceInChests = mod.ItemType("TMMCSnowOre");
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers)
                {
                    if (WorldGen.genRand.Next(10) == 0)
                    {
                        for (int i = 0; i < 40; i++)
                        {
                            if (chest.item[i].type == 0)
                            {
                                chest.item[i].SetDefaults(itemToPlaceInChests);
                                chest.item[i].stack = WorldGen.genRand.Next(5, 15);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void OreGenerationOnBossDeath()
        {

        }
    }
}
