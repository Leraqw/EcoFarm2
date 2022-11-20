using Code.ECS.Components.ComplexComponentTypes;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;

namespace Code.Utils.Extensions.Entitas
{
	public static class ResourcesExtensions
	{
		public static GameEntity CreateResource(this GameContext @this, string name, IResourceConfig resource)
			=> @this.CreateEntity()
			        .Do((e) => e.AddDebugName(name))
			        .Do((e) => e.AddProgressBar(NewValue(resource)))
			        .Do((e) => e.AddRenewPrice(resource.RenewPrice))
			        .Do((e) => e.AddConsumable(e.creationIndex))
		/**/;

		public static void Consume(this GameEntity entity)
			=> entity.GetResource().DecreaseResourceCurrentValue(entity.consumptionCoefficient);

		public static bool IsResourceExhausted(this GameEntity entity)
			=> entity.GetResource().progressBar.Value.Current <= entity.consumptionCoefficient;

		public static void DecreaseResourceCurrentValue(this GameEntity @this, int value)
			=> @this.UpdateResourceCurrentValue(@this.progressBar.Value.Current - value);
		
		public static void IncreaseResourceCurrentValue(this GameEntity @this, int value)
			=> @this.UpdateResourceCurrentValue(@this.progressBar.Value.Current + value);

		public static void UpdateResourceCurrentValue(this GameEntity @this, float value)
			=> @this.ReplaceProgressBar(new ProgressBarValues { Max = @this.progressBar.Value.Max, Current = value });

		private static GameEntity GetResource(this GameEntity @this)
			=> Contexts.game.GetEntityWithConsumable(@this.consumer);

		private static ProgressBarValues NewValue(IResourceConfig resource)
			=> new() { Max = resource.MaxValue, Current = resource.StartValue };

		private static Contexts Contexts => Contexts.sharedInstance;
	}
}