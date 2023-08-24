namespace EcoFarm
{
	public static class DroughtTimerExtensions
	{
		public static GameEntity ResetDroughtTimer(this GameEntity @this)
			=> @this.Do((e) => e.AddDuration(Configuration.Balance.Watering.DroughtDuration));

		// TODO: or tree wrapper
		private static IConfigurationService Configuration => ServicesSingleton.Instance.Configuration;
	}
}