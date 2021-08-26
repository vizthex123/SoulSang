using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ScarabNecklace : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarab Necklace");
			Tooltip.SetDefault("A necklace combined with a scroll of power\nSure to bring the wearer great skill with their summons.\nIncreases minion damage and knockback by 20%\n+2 Max Minions");
		}
		
        public override void SetDefaults()
        {
            Item.width = 25;
            Item.height = 25;
            Item.maxStack = 1;
            Item.rare = 1;
			Item.accessory = true;
			Item.value = Item.buyPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.maxMinions+= 2;
			player.minionDamage += 0.20f;
			player.minionKB+= 0.25f; // Should be a bit more than the Hercules Beetle
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.PapyrusScarab, 1)
				.AddIngredient(ItemID.PygmyNecklace, 1)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}