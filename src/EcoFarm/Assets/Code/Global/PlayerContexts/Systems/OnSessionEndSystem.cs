using System.Collections.Generic;
using Entitas;
using static EcoFarm.SessionResult;

namespace EcoFarm
{
	public sealed class OnSessionEndSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly ISceneTransferService _sceneTransferService;

		public OnSessionEndSystem(Contexts contexts, ISceneTransferService sceneTransferService)
			: base(contexts.player)
			=> _sceneTransferService = sceneTransferService;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(PlayerMatcher.SessionResult);

		protected override bool Filter(PlayerEntity entity) => entity.sessionResult.Value != None;

		protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(OnEnd);

		private void OnEnd(PlayerEntity entity) => _sceneTransferService.ToGameResultScene();
	}
}