using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static Code.PlayerContext.CustomTypes.SessionResult;

namespace Code.PlayerContext.Systems
{
	public sealed class OnSessionEndSystem : ReactiveSystem<PlayerEntity>
	{
		public OnSessionEndSystem(Contexts contexts)
			: base(contexts.player) { }

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(PlayerMatcher.SessionResult);

		protected override bool Filter(PlayerEntity entity) => entity.sessionResult != None;

		protected override void Execute(List<PlayerEntity> entites) => entites.ForEach(OnEnd);

		private static void OnEnd(PlayerEntity entity) 
			=> Debug.Log($"At this moment, the session has ended with the result: {entity.sessionResult.Value}");
	}
}