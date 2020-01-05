using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.Localization;
using System.Threading;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using System.IO;

namespace TMMCNpcs
{
    public class TMMCNpcsWorld : ModWorld
    {
        public static bool DownedTMMCBoss = false;

        public override void Initialize()
        {
            DownedTMMCBoss = false;
        }

        public override TagCompound Save()
        {
            var Downed = new List<string>();
            if (DownedTMMCBoss) Downed.Add("tmmcBoss");

            return new TagCompound
            {
                {
                    "Version", 0
                },
                {
                    "Downed", Downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var Downed = tag.GetList<string>("Downed");
            DownedTMMCBoss = Downed.Contains("tmmcBoss");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                DownedTMMCBoss = flags[0];
            }
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = DownedTMMCBoss;

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            DownedTMMCBoss = flags[0];
        }
    }
}
