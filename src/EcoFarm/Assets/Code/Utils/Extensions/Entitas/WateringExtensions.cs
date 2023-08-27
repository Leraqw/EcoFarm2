using System;
using UnityEngine;

namespace EcoFarm
{
	public static class WateringExtensions
	{
		public static GameEntity IncreaseWatering(this GameEntity @this, int value)
			=> @this.UpdateWatering((w) => w + value);

		public static GameEntity DecreaseWatering(this GameEntity @this, int value)
			=> @this.UpdateWatering((w) => w - value);

		private static GameEntity UpdateWatering(this GameEntity @this, Func<int, int> with)
		{
			@this.ReplaceWatering(with(@this.watering.Value));
			return @this;
		}

		public static GameEntity TreeIsDead(this GameEntity @this, Sprite sprite)
		{
			@this.RemoveWatering();
			@this.AddSpriteToLoad(sprite);
			@this.isFruitful = false;
			return @this;
		}
	}
}