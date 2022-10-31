using Code.ECS.Systems.Common;
using Code.ECS.Systems.Input;
using Code.ECS.Systems.Inventory;
using Code.ECS.Systems.Product;
using Code.ECS.Systems.Product.Fruit;
using Code.ECS.Systems.Product.Fruit.Falling;
using Code.ECS.Systems.Product.Fruit.FruitStates;
using Code.ECS.Systems.Product.Fruit.Growing;
using Code.ECS.Systems.Tree;
using Code.ECS.Systems.View;
using Code.ECS.Systems.Warehouse;
using Code.Services.Interfaces;
using Code.Utils.Extensions;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(IAllServices services)
			: base(nameof(AllSystems))
		{
			var contexts = Contexts.sharedInstance;
			Add(new ServicesRegistrationSystems(contexts, services));

			Add(new InitializeInventorySystem(contexts));
			Add(new CreateInventoryItemsSystem(contexts));

			Add(new EmitPositionsForTreeSpawnSystem(contexts));
			Add(new SpawnTreeSystem(contexts));
			Add(new SpawnFruitSystem(contexts));
			Add(new SpawnBedsPlugsSystem(contexts));
			Add(new SpawnWarehouseSystem(contexts));
			
			Add(new OnMouseClickSystem(contexts));
			Add(new CollectToWarehouseSystem(contexts));
			
			Add(new LoadViewForEntitySystem(contexts));
			Add(new BindViewsSystem(contexts));

			Add(new WaitBeforeGrowingSystem(contexts));
			Add(new GrowingSystem(contexts));
			Add(new WaitAfterGrowingSystem(contexts));
			Add(new CheckGrowthUpSystem(contexts));
			
			Add(new MarkFallingSystem(contexts));
			Add(new FallingSystem(contexts));
			Add(new CheckFellUpSystem(contexts));
			Add(new DetachFromTreeSystem(contexts));
			Add(new MarkFellFruitAsPickableSystem(contexts));

			Add(new DurationSystem(contexts));
			Add(new CheckDurationUpSystem(contexts));
			
			Add(new RemoveTargetsOnTimeUpSystem(contexts));

			
			Add(new GameCleanupSystems(contexts));
			Add(new GameEventSystems(contexts));
		}

		public void OnUpdate() => this.Do(Execute).Do(Cleanup);
		
		private static void Execute(AllSystems @this) => @this.Execute();

		private static void Cleanup(AllSystems @this) => @this.Cleanup();
	}
}