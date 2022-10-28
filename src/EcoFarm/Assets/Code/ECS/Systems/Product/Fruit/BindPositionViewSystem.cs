﻿using System;
using System.Collections.Generic;
using Code.Unity.ViewListeners;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class BindPositionViewSystem : ReactiveSystem<GameEntity>
	{
		public BindPositionViewSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.View, GameMatcher.RequireViewOfType, GameMatcher.Position);

		protected override bool Filter(GameEntity entity)
			=> entity.requireViewOfType.Value == typeof(PositionView);

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(AddListener);

		private static void AddListener(GameEntity entity) => entity.AddPositionListener(GetViewComponent(entity));

		private static PositionView GetViewComponent(GameEntity entity)
			=> entity.view.Value.GetComponent<PositionView>() ?? throw new NullReferenceException();
	}
}