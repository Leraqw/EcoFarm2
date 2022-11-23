using System.Collections.Generic;
using Entitas;
using SessionResult = Code.Global.PlayerContexts.CustomTypes.SessionResult;

namespace Code.Global.PlayerContexts.Systems
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

		protected override bool Filter(PlayerEntity entity) => entity.sessionResult == SessionResult.Victory;

		protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(Save);

		private void Save(PlayerEntity entity) 
			=> Player.ReplaceCompletedLevelsCount(Player.completedLevelsCount.Value + 1);
	}
}