using System;

namespace Code.Utils.Extensions.Entitas
{
	public static class WateringExtensions
	{
		public static GameEntity UpdateWatering(this GameEntity entity, Func<int, int> with)
		{
			entity.ReplaceWatering(with(entity.watering.Value));
			return entity;
		}
	}
}