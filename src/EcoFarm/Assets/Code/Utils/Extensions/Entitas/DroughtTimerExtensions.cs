using static Code.Utils.StaticClasses.Constants.Balance.Watering;

namespace Code.Utils.Extensions.Entitas
{
	public static class DroughtTimerExtensions
	{
		public static GameEntity ResetDroughtTimer(this GameEntity @this)
			=> @this.Do((e) => e.AddDuration(DroughtDuration));
	}
}