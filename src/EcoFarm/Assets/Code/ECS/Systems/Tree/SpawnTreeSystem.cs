using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
	{
		private const float Radius = 2f;

		private readonly Contexts _contexts;
		private readonly IConfigurationService _configurationService;

		public SpawnTreeSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
			_contexts = contexts;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		private ITreeConfig TreeConfiguration => _configurationService.Balance.Tree;

		private Material DefaultMaterial => _configurationService.Resource.Material.Default;

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
			e.isIsInRadius = false;
			e.RemoveRequireTreeOnPosition();
			e.AddWatering(TreeConfiguration.InitialWatering);
			e.AddRadius(Radius);
			e.AddMaterial(DefaultMaterial);
		}
	}
}