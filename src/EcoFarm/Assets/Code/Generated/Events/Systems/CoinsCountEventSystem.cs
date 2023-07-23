//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class CoinsCountEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ICoinsCountListener> _listenerBuffer;

    public CoinsCountEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ICoinsCountListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.CoinsCount)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasCoinsCount && entity.hasCoinsCountListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.coinsCount;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.coinsCountListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnCoinsCount(e, component.value);
            }
        }
    }
}
