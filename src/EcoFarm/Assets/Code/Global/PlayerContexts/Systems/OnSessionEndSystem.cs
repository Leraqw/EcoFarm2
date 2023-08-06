using System.Collections.Generic;

using Entitas;
using static EcoFarm.SessionResult;

namespace EcoFarm
{
	public sealed class OnSessionEndSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly Contexts _contexts;

		public OnSessionEndSystem(Contexts contexts)
			: base(contexts.player)
			=> _contexts = contexts;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(PlayerMatcher.SessionResult);

		private ISceneTransferService SceneTransfer => _contexts.services.sceneTransferService.Value;

		protected override bool Filter(PlayerEntity entity) => entity.sessionResult.Value != None;

		protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(OnEnd);

		private void OnEnd(PlayerEntity entity) => SceneTransfer.ToGameResultScene();
	}
}