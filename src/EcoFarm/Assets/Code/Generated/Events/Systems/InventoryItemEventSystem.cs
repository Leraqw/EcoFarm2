//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class InventoryItemEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IInventoryItemListener> _listenerBuffer;

    public InventoryItemEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IInventoryItemListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.InventoryItem)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasInventoryItem && entity.hasInventoryItemListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.inventoryItem;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.inventoryItemListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnInventoryItem(e, component.value);
            }
        }
    }
}
