using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Watering.Drought
{
	public sealed class SpawnDroughtTimerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnDroughtTimerSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isDroughtTimer = true);
	}
}