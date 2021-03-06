using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class BlueKnightBreastplate : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.value = 10000;
			item.rare = 2;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Knight Breastplate");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GrayKnightBreastplate", 3);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
