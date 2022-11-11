using System;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Utils.Extensions.Entitas
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
	}
}