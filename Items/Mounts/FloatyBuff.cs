﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Items.Mounts
{
    public class FloatyBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Floaty Rug");
            Description.SetDefault("Warning: flight not included.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<Items.Mounts.FloatyCarpet>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}