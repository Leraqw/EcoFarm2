using Code.ECS.Components.ComplexComponentTypes;
using Code.Unity.Containers;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class InitializeResourcesSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeResourcesSystem(Contexts contexts) => _contexts = contexts;

		private WindowResources WindowsResources => _contexts.services.uiService.Value.Windows.Resources;

		public void Initialize()
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("Resource - Energy"))
			         .Do((e) => e.isEnergyResource = true)
			         .Do((e) => e.AddProgressBar(new ProgressBarValues()))
			         .Do((e) => e.AddView(WindowsResources.EnergyIndicator.gameObject));

			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("Resource - Water"))
			         .Do((e) => e.isWaterResource = true)
			         .Do((e) => e.AddProgressBar(new ProgressBarValues()))
			         .Do((e) => e.AddView(WindowsResources.WaterIndicator.gameObject));
		}
	}
}