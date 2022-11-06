using System;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config;
using Code.Unity.SO.Configuration;

namespace Code.Utils.Extensions.Entitas
{
	public static class WateringExtensions
	{
		public static GameEntity IncreaseWatering(this GameEntity @this, int value)
			=> @this.UpdateWatering((w) => w + value);
		
		public static GameEntity DecreaseWatering(this GameEntity @this, int value)
			=> @this.UpdateWatering((w) => w - value);

		public static GameEntity UpdateWatering(this GameEntity @this, Func<int, int> with)
		{
			@this.ReplaceWatering(with(@this.watering.Value));
			return @this;
		}
		
		public static string GetActualBucketSprite(this GameEntity entity) 
			=> entity.isFilled ? Sprite.Bucket.Filled : Sprite.Bucket.Empty;

		private static ISpriteConfig Sprite => Configuration.ResourcePath.Sprite;

		private static IConfigurationService Configuration => Contexts.sharedInstance.GetConfiguration();
	}
}