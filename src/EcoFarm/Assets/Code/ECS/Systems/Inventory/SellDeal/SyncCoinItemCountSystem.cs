using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.Inventory.SellDeal
{
	public sealed class SyncCoinItemCountSystem : ReactiveSystem<ContextEntity>
	{
		public SyncCoinItemCountSystem(Contexts contexts)
			: base(contexts.context) { }

		protected override ICollector<ContextEntity> GetTrigger(IContext<ContextEntity> context)
			=> context.CreateCollector(ContextMatcher.Matcher);

		protected override bool Filter(ContextEntity entity)
			=> true;

		protected override void Execute(List<ContextEntity> entites)
		{
			foreach (ContextEntity e in entites)
			{
				
			}
		}
	}
}