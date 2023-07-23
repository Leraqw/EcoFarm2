using System.Collections.Generic;
using Entitas;
using static PlayerMatcher;

namespace Code
{
	public sealed class DisableIfNoCurrentPlayerSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<PlayerEntity> _buttons;

		public DisableIfNoCurrentPlayerSystem(Contexts contexts) : base(contexts.player)
		{
			_contexts = contexts;
			_buttons = contexts.player.GetGroup(ForPlayerButton);
		}

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(CurrentPlayer.AddedOrRemoved());

		protected override bool Filter(PlayerEntity entity) => true;

		protected override void Execute(List<PlayerEntity> entites)
		{
			foreach (var button in _buttons)
			{
				button.ReplaceInteractable(_contexts.player.currentPlayerEntity != null);
			}
		}
	}
}