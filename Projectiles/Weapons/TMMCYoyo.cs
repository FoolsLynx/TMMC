using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace TMMC.Projectiles.Weapons
{
    public class TMMCYoyo : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 7.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 235f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 11.5f;
        }

        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.Size = new Vector2(16);
            projectile.aiStyle = 99;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;
        }
    }
}
