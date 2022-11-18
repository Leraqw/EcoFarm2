using Code.Services.Game.Interfaces.Config;
using Code.Unity.Containers;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class InitializeResourcesSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeResourcesSystem(Contexts contexts) => _contexts = contexts;

		private WindowResources WindowsResources => _contexts.services.uiService.Value.Windows.Resources;

		private IBalanceConfig Balance => _contexts.services.configurationService.Value.Balance;

		public void Initialize()
			=> _contexts.game.Do(InitializeWater)
			            .Do(InitializeEnergy);

		private void InitializeEnergy(GameContext context)
			=> context.CreateResource("Resource - Energy", Balance.Energy)
			          .Do((e) => e.isEnergyResource = true)
			          .Do((e) => e.AddView(WindowsResources.EnergyIndicator.gameObject))
		/**/;

		private void InitializeWater(GameContext context)
			=> context.CreateResource("Resource - Water", Balance.Water)
			          .Do((e) => e.isWaterResource = true)
			          .Do((e) => e.AddView(WindowsResources.WaterIndicator.gameObject))
		/**/;
	}
}