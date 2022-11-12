using System.Linq;
using Code.Utils.Extensions;
using EcoFarmDataModule;
using Entitas;

namespace Code.ECS.Systems.Level
{
	public sealed class CreateLevelTimerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateLevelTimerSystem(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.services.dataService.Value.Storage;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("LevelTimer"))
			            .Do((e) => e.AddDuration(Storage.Levels.First().SecondsForLevel));
	}
}