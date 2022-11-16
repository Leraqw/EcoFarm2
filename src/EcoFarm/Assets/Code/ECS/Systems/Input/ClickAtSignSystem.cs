using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Input
{
	public sealed class ClickAtSignSystem : ReactiveSystem<GameEntity>
	{
		public ClickAtSignSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Sign));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(OpenWindow);

		private void OpenWindow(GameEntity click) => Debug.Log("Open window"); 
	}
}