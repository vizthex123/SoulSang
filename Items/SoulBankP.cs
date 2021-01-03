/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class SoulBankP : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Platinum Soul Bank");
			Tooltip.SetDefault("A bundle of Platinum Coins bound to some Souls.\nPersists after death.\nCannot be burned in Lava.\nNote: Mediumcore characters will still drop them, I can't program around that yet.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.rare = 1;
			item.maxStack = 40;
			item.value = Item.sellPrice(25, 0, 0, 0);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 3);
			recipe.AddIngredient(ItemID.PlatinumCoin, 25);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulBankP"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.SetResult(ItemID.PlatinumCoin, 25);
			recipe.AddRecipe();
		}
	}
}
*/