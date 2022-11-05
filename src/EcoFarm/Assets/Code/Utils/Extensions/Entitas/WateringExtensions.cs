using System;
using static Code.Utils.StaticClasses.Constants.ResourcePath;

namespace Code.Utils.Extensions.Entitas
{
	public static class WateringExtensions
	{
		public static GameEntity UpdateWatering(this GameEntity entity, Func<int, int> with)
		{
			entity.ReplaceWatering(with(entity.watering.Value));
			return entity;
		}
		
		public static string GetActualBucketSprite(this GameEntity entity) 
			=> entity.isFilled ? Sprite.Bucket.Filled : Sprite.Bucket.Empty;
	}
}