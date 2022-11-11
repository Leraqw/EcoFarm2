using System.Linq;
using Code.Utils.Extensions;
using EcoFarmDataModule;
using Entitas;

namespace Code.ECS.Systems.Goals
{
	public sealed class CreateGoalForLevelSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateGoalForLevelSystem(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Levels.First().Goals.ForEach(Create);

		private void Create(Goal goal)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddGoal(goal))
			            .Do((e) => e.AddDebugName($"Goal {goal.TargetQuantity} – {goal.GetType().Name}"));
	}
}