using System;



using UnityEngine;

namespace Code
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

		public static Sprite GetActualBucketSprite(this GameEntity entity)
			=> entity.isFilled ? Sprite.Bucket.Filled : Sprite.Bucket.Empty;

		private static ISpriteConfig Sprite => Configuration.Resource.Sprite;

		private static IConfigurationService Configuration => Contexts.sharedInstance.GetConfiguration();

		public static GameEntity TreeIsDead(this GameEntity @this, Sprite sprite)
			=> @this
			   .Do((e) => e.RemoveWatering())
			   .Do((e) => e.AddSpriteToLoad(sprite))
			   .Do((e) => e.isFruitful = false);
	}
}