using Terraria.ModLoader;

namespace CalValEX.Items.Tiles.Plants
{
    internal class BelchingCoral : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sulphuric Coral");
            Tooltip
                .SetDefault("Don't put your bare hand into it");
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
            item.createTile = ModContent.TileType<BelchingCoralPlaced>();
            item.width = 12;
            item.height = 12;
            item.rare = 5;
        }
    }
}