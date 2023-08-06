using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ClickOnBuildItemSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public ClickOnBuildItemSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private Item Coins => _contexts.game.coinEntity.inventoryItem.Value;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(UiElement, MouseDown, Building));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Buy, @if: EnoughMoney);

		private bool EnoughMoney(GameEntity building) => Coins.Count >= building.building.Value.Price;

		private void Buy(GameEntity building)
			=> building.Do(DecreaseMoneyCount)
			           .Do((e) => e.isBought = true);

		private void DecreaseMoneyCount(GameEntity building)
			=> _contexts.game.inventoryEntity.DecreaseCoinsCount(building.building.Value.Price);
	}
}