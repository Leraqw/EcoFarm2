using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class OnResourceButtonClickSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public OnResourceButtonClickSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private Item Coins => _contexts.game.coinEntity.inventoryItem.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(ProgressBar, MouseDown));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Renew, @if: EnoughMoney);

		private bool EnoughMoney(GameEntity resource) => Coins.Count >= resource.renewPrice.Value;

		private void Renew(GameEntity resource)
			=> resource.Do((e) => e.UpdateResourceCurrentValue(e.progressBar.Value.Max))
			           .Do((e) => _contexts.game.inventoryEntity.DecreaseCoinsCount(e.renewPrice.Value));
	}
}