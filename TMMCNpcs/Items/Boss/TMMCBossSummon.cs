using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace TMMCNpcs.Items.Boss
{
    public class TMMCBossSummon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TMMC Boss Summon");
            Tooltip.SetDefault("Summons TMMC Boss");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.maxStack = 20;
            item.rare = 4;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            // We make sure that the boss doesn't already exist
            return !NPC.AnyNPCs(mod.NPCType("TMMCBoss"));
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(SoundID.Roar, player.position);
            if(Main.netMode != 1)
            {
                NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("TMMCBoss"));
            }
            return true;
        }
    }
}
