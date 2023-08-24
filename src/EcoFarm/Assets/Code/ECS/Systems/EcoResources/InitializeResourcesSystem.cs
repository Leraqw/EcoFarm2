using Entitas;

namespace EcoFarm
{
	public sealed class InitializeResourcesSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;
		private readonly IConfigurationService _configurationService;

		public InitializeResourcesSystem
		(
			Contexts contexts,
			IUiService uiService,
			IConfigurationService configurationService
		)
		{
			_contexts = contexts;
			_uiService = uiService;
			_configurationService = configurationService;
		}

		private WindowResources WindowsResources => _uiService.Windows.Resources;

		private IBalanceConfig Balance => _configurationService.Balance;

		public void Initialize() => _contexts.game.storage.Value.Resources.ForEach(Create);

		private void Create(Resource resource)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName($"Resource – {resource.Title}"))
			            .Do((e) => e.AddResource(resource))
			            .Do(InitializeEnergy, @if: resource.Title == Constants.ElectricityName)
			            .Do(InitializeWater, @if: resource.Title == Constants.WaterName);

		private void InitializeEnergy(GameEntity entity)
			=> entity
			   .Do((e) => e.InitializeAsResource(Balance.Energy))
			   .Do((e) => e.isEnergyResource = true)
			   .Do((e) => e.AddView(WindowsResources.EnergyIndicator.gameObject));

		private void InitializeWater(GameEntity context)
			=> context
			   .Do((e) => e.InitializeAsResource(Balance.Water))
			   .Do((e) => e.isWaterResource = true)
			   .Do((e) => e.AddView(WindowsResources.WaterIndicator.gameObject));
	}
}