using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items
{
    public class CalaFumoYeetable : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calamitas Plushie (Throwable)");
            Tooltip.SetDefault("A dark artifact that must be handled with care\n" + "Can be thrown");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.width = 44;
            item.height = 44;
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.rare = 6;
            item.useAnimation = 20;
            item.useTime = 20;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = 20;
            item.shoot = mod.ProjectileType("CalaFumo");
            item.shootSpeed = 6f;
        }

        public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<CalamitasFumo>());
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}