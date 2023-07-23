using System.Collections.Generic;
using System.Linq;




using Entitas;

namespace Code
{
	public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireTreeOnPosition);

		protected override bool Filter(GameEntity entity) => entity.hasRequireTreeOnPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity entry)
			=> entry.Do((e) => e.AddDebugName("Tree"))
			        .Do((e) => e.MakeAttachable())
			        .Do((e) => e.AddViewPrefab(Resource.Prefab.Tree))
			        .Do((e) => e.AddSpawnPosition(e.requireTreeOnPosition.Value))
			        .Do((e) => e.AddTree(_contexts.game.storage.Value.Trees.First()))
			        .Do((e) => e.isFruitful = true)
			        .Do((e) => e.RemoveRequireTreeOnPosition());
	}
}