﻿using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class OnToggleActivityButtonClickSystem : ReactiveSystem<GameEntity>
	{
		public OnToggleActivityButtonClickSystem(Contexts contexts) : base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(TargetActivity, AttachedTo));

		protected override bool Filter(GameEntity entity) => entity.hasTargetActivity;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

		private static void Toggle(GameEntity request)
		{
			var activity = request.targetActivity;
			var window = request.GetAttachableEntity();
			
			if (activity.Value
			    && window.isRequirePreparation)
			{
				window.isPreparationInProcess = true;
				return;
			}
            
			window.ReplaceActivate(activity.Value);
			request.isDestroy = true;
		}
	}
}