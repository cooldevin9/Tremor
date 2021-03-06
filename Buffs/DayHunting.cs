using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class DayHunting : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Day Hunting");
			Description.SetDefault("Increases all stats during daytime");
		}

		public override void Update(Player player, ref int buffIndex)
		{

			if (Main.dayTime)
			{
				player.meleeDamage += 0.15f;
				player.meleeCrit += 12;
				player.magicDamage += 0.15f;
				player.magicCrit += 12;
				player.rangedDamage += 0.15f;
				player.rangedCrit += 12;
				player.minionDamage += 0.15f;
				player.thrownDamage += 0.15f;
				player.moveSpeed += 0.25f;
			}
		}
	}
}
