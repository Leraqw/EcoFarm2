//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class PlayerModeButtonsEnabledEventSystem : Entitas.ReactiveSystem<PlayerEntity> {

    readonly System.Collections.Generic.List<IPlayerModeButtonsEnabledListener> _listenerBuffer;

    public PlayerModeButtonsEnabledEventSystem(Contexts contexts) : base(contexts.player) {
        _listenerBuffer = new System.Collections.Generic.List<IPlayerModeButtonsEnabledListener>();
    }

    protected override Entitas.ICollector<PlayerEntity> GetTrigger(Entitas.IContext<PlayerEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(PlayerMatcher.PlayerModeButtonsEnabled)
        );
    }

    protected override bool Filter(PlayerEntity entity) {
        return entity.hasPlayerModeButtonsEnabled && entity.hasPlayerModeButtonsEnabledListener;
    }

    protected override void Execute(System.Collections.Generic.List<PlayerEntity> entities) {
        foreach (var e in entities) {
            var component = e.playerModeButtonsEnabled;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.playerModeButtonsEnabledListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnPlayerModeButtonsEnabled(e, component.Value);
            }
        }
    }
}