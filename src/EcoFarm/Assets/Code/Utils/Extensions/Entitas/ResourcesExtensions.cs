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

		private static ProgressBarValues NewValue(IResourceConfig resource)
			=> new() { Max = resource.MaxValue, Current = resource.StartValue };
	}
}