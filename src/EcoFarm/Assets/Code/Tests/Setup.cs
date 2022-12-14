using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config;
using NSubstitute;

namespace Code.Tests
{
	public class Setup
	{
		public static void Services(Contexts contexts)
		{
			var service = contexts.services.CreateEntity();
			service.AddConfigurationService(Substitute.For<IConfigurationService>());
			service.AddSceneObjectsService(Substitute.For<ISpawnPointsService>());
		}
	}
}