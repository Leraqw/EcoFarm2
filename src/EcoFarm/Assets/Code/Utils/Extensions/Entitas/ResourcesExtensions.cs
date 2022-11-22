using Code.ECS.Components.ComplexComponentTypes;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;

namespace Code.Utils.Extensions.Entitas
{
	public static class ResourcesExtensions
	{
		public static GameEntity InitializeAsResource(this GameEntity @this, IResourceConfig resource)
			=> @this
			   .Do((e) => e.AddProgressBar(NewValue(resource)))
			   .Do((e) => e.AddRenewPrice(resource.RenewPrice))
			   .Do((e) => e.AddConsumable(e.creationIndex))
		/**/;

		public static void Consume(this GameEntity @this)
			=> @this.GetResource().DecreaseResourceCurrentValue(@this.consumptionCoefficient);

		public static void Produce(this GameEntity @this)
			=> @this.GetResource().IncreaseResourceCurrentValue(@this.efficiencyCoefficient);

		public static bool IsResourceExhausted(this GameEntity entity)
			=> entity.GetResource().progressBar.Value.Current <= entity.consumptionCoefficient;

		public static void DecreaseResourceCurrentValue(this GameEntity @this, int value)
			=> @this.UpdateResourceCurrentValue(@this.progressBar.Value.Current - value);

		public static void IncreaseResourceCurrentValue(this GameEntity @this, int value)
			=> @this.UpdateResourceCurrentValue(@this.progressBar.Value.Current + value);

		public static void UpdateResourceCurrentValue(this GameEntity @this, float value)
			=> @this.ReplaceProgressBar(new ProgressBarValues { Max = @this.progressBar.Value.Max, Current = value });

		public static GameEntity GetResource(this GameEntity @this)
			=> Contexts.game.GetEntityWithConsumable(@this.hasProduceResource ? @this.produceResource : @this.consumer);

		public static GameEntity GetFactoryResource(this GameEntity @this)
			=> Contexts.game.GetEntityWithResource(@this.factory.Value.Resource);

		public static GameEntity GetGeneratorResource(this GameEntity @this)
			=> Contexts.game.GetEntityWithResource(@this.generator.Value.Resource);

		private static ProgressBarValues NewValue(IResourceConfig resource)
			=> new() { Max = resource.MaxValue, Current = resource.StartValue };

		private static Contexts Contexts => Contexts.sharedInstance;
	}
}