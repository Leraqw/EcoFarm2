using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
	{
		public SpawnTreeSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireTreeOnPosition);

		protected override bool Filter(GameEntity entity)
			=> entity.hasRequireTreeOnPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private static void Spawn(GameEntity entry)
			=> entry
			   .Do((e) => e.isTree = true)
			   .Do((e) => e.AddRequireView("Trees/Prefabs/Tree"))
			   .Do((e) => e.AddSpawnPosition(e.requireTreeOnPosition.Value))
			   .Do((e) => e.RemoveRequireTreeOnPosition());
	}
}