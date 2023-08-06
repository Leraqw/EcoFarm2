using EcoFarmModel;
using Entitas;

namespace EcoFarm
{
	public sealed class InitializeResourcesSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeResourcesSystem(Contexts contexts) => _contexts = contexts;

		private WindowResources WindowsResources => _contexts.services.uiService.Value.Windows.Resources;

		private IBalanceConfig Balance => _contexts.services.configurationService.Value.Balance;

		public void Initialize() => _contexts.game.storage.Value.Resources.ForEach(Create);

		private void Create(Resource resource)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName($"Resource – {resource.Title}"))
			            .Do((e) => e.AddResource(resource))
			            .Do(InitializeEnergy, @if: resource.Title == Constants.ElectricityName)
			            .Do(InitializeWater, @if: resource.Title == Constants.WaterName)
		/**/;

		private void InitializeEnergy(GameEntity entity)
			=> entity
			   .Do((e) => e.InitializeAsResource(Balance.Energy))
			   .Do((e) => e.isEnergyResource = true)
			   .Do((e) => e.AddView(WindowsResources.EnergyIndicator.gameObject))
		/**/;

		private void InitializeWater(GameEntity context)
			=> context
			   .Do((e) => e.InitializeAsResource(Balance.Water))
			   .Do((e) => e.isWaterResource = true)
			   .Do((e) => e.AddView(WindowsResources.WaterIndicator.gameObject))
		/**/;
	}
}