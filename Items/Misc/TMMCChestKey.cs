using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TMMC.Items.Misc
{
    public class TMMCChestKey : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FrozenKey);
        }
    }
}
