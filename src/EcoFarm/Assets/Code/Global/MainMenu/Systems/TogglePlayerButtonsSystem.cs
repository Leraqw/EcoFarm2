using System.Collections.Generic;
using Entitas;
using Zenject;
using static PlayerMatcher;

namespace EcoFarm
{
	public class TogglePlayerButtonsSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly PlayerContext _context;

		[Inject]
		public TogglePlayerButtonsSystem(Contexts contexts, IDataProviderService dataProvider)
			: base(contexts.player)
			=> _context = contexts.player;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(ForPlayerButton);

		protected override bool Filter(PlayerEntity entity) => entity.isForPlayerButton;

		protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ToggleEnabled);

		private void ToggleEnabled(PlayerEntity playerButton)
			=> playerButton.ReplaceInteractable(_context.isCurrentPlayer);
	}
}