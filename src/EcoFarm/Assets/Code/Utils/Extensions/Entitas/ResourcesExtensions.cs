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
			        .Do((e) => e.AddConsumable(e.creationIndex));

		public static void Consume(this GameEntity entity)
			=> GetResourceOf(entity).DecreaseResourceCurrentValue(entity.consumptionCoefficient);

		public static bool IsResourceExhausted(this GameEntity entity)
			=> GetResourceOf(entity).progressBar.Value.Current <= 0;
		
		private static void DecreaseResourceCurrentValue(this GameEntity resource, int value)
		{
			var newCurrent = resource.progressBar.Value.Current - value;
			var oldMax = resource.progressBar.Value.Max;
			resource.ReplaceProgressBar(new ProgressBarValues { Max = oldMax, Current = newCurrent });
		}

		private static GameEntity GetResourceOf(GameEntity entity)
			=> Contexts.game.GetEntityWithConsumable(entity.consumer);

		private static ProgressBarValues NewValue(IResourceConfig resource)
			=> new() { Max = resource.MaxValue, Current = resource.StartValue };

		private static Contexts Contexts => Contexts.sharedInstance;
	}
}