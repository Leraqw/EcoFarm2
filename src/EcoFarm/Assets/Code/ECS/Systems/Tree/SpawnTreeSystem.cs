using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace EcoFarm
{
	public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		private ITreeConfig Configuration => _contexts.GetConfiguration().Balance.Tree;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.RequireTreeOnPosition);

		protected override bool Filter(GameEntity entity) => entity.hasRequireTreeOnPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

		private void Spawn(GameEntity e)
		{
			e.AddDebugName("Tree");
			e.MakeAttachable();
			e.AddViewPrefab(Resource.Prefab.Tree);
			e.AddSpawnPosition(e.requireTreeOnPosition.Value);
			e.AddTree(_contexts.game.storage.Value.Trees.First());
			e.isFruitful = true;
			e.RemoveRequireTreeOnPosition();
			e.AddWatering(Configuration.InitialWatering);
		}
	}
}