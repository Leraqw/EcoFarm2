using Code.ECS.Components.ComplexComponentTypes;
using Code.Services.Game.Interfaces.Config;
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

		private IBalanceConfig Balance => _contexts.services.configurationService.Value.Balance;

		private int EnergyStart => Balance.Energy.StartValue;

		private int EnergyMax => Balance.Energy.MaxValue;

		private int WaterStart => Balance.Water.StartValue;

		private int WaterMax => Balance.Water.MaxValue;

		public void Initialize()
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("Resource - Energy"))
			         .Do((e) => e.isEnergyResource = true)
			         .Do((e) => e.AddProgressBar(new ProgressBarValues { Max = EnergyMax, Current = EnergyStart }))
			         .Do((e) => e.AddView(WindowsResources.EnergyIndicator.gameObject))
			         .Do((e) => e.AddConsumable(e.creationIndex))
				;

			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("Resource - Water"))
			         .Do((e) => e.isWaterResource = true)
			         .Do((e) => e.AddProgressBar(new ProgressBarValues { Max = WaterMax, Current = WaterStart }))
			         .Do((e) => e.AddView(WindowsResources.WaterIndicator.gameObject))
			         .Do((e) => e.AddConsumable(e.creationIndex))
				;
		}
	}
}