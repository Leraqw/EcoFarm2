using System.Collections.Generic;
using Entitas;

namespace EcoFarm
{
	public sealed class SaveProgressSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly Contexts _contexts;

		public SaveProgressSystem(Contexts contexts)
			: base(contexts.player)
			=> _contexts = contexts;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(PlayerMatcher.SessionResult);

		private PlayerEntity Player => _contexts.player.currentPlayerEntity;

		protected override bool Filter(PlayerEntity entity) => entity.sessionResult.Value == SessionResult.Victory;

		protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(Save);

		private void Save(PlayerEntity entity)
		{
			var currentLevel = Player.selectedLevel.Value + 1;
			if (currentLevel > Player.completedLevelsCount.Value)
			{
				Player.ReplaceCompletedLevelsCount(currentLevel);
			}
		}
	}
}