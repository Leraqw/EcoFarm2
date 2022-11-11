using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Tree
{
	public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IResourcePathConfig ResourcePath => _contexts.GetConfiguration().ResourcePath;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireTreeOnPosition);

		protected override bool Filter(GameEntity entity) => entity.hasRequireTreeOnPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity entry)
			=> entry.Do((e) => e.AddDebugName("Tree"))
			        .Do((e) => e.AddAttachableIndex(e.creationIndex))
			        .Do((e) => e.AddViewPrefab(ResourcePath.Prefab.Tree))
			        .Do((e) => e.AddSpawnPosition(e.requireTreeOnPosition))
			        .Do((e) => e.isTree = true)
			        .Do((e) => e.isFruitful = true)
			        .Do((e) => e.RemoveRequireTreeOnPosition());
	}
}