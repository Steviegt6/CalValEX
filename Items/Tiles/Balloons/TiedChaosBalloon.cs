using Terraria.ModLoader;

namespace CalValEX.Items.Tiles.Balloons
{
    internal class TiedChaosBalloon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tied Chaos Balloon");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = ModContent.TileType<TiedChaosBalloonPlaced>();
            item.width = 16;
            item.height = 40;
            item.rare = 4;
        }
    }
}