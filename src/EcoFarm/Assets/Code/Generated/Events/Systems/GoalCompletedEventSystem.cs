//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GoalCompletedEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IGoalCompletedListener> _listenerBuffer;

    public GoalCompletedEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IGoalCompletedListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.GoalCompleted)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasGoalCompleted && entity.hasGoalCompletedListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.goalCompleted;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.goalCompletedListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGoalCompleted(e, component.value);
            }
        }
    }
}
