

using static Contexts;

namespace EcoFarm
{
	public static class DroughtTimerExtensions
	{
		public static GameEntity ResetDroughtTimer(this GameEntity @this)
			=> @this.Do((e) => e.AddDuration(Configuration.Balance.Watering.DroughtDuration));

		private static IConfigurationService Configuration => sharedInstance.GetConfiguration();
	}
}