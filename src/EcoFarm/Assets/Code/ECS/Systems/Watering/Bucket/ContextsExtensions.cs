using Code.Services.Game.Interfaces.Config;

namespace Code.ECS.Systems.Watering.Bucket
{
	public static class ContextsExtensions
	{
		public static IConfigurationService GetConfiguration(this Contexts @this)
			=> @this.services.configurationService.Value;
	}
}