//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DraggingStartComponent draggingStart { get { return (DraggingStartComponent)GetComponent(GameComponentsLookup.DraggingStart); } }
    public bool hasDraggingStart { get { return HasComponent(GameComponentsLookup.DraggingStart); } }

    public void AddDraggingStart(Code.DraggingStartComponent newValue) {
        var index = GameComponentsLookup.DraggingStart;
        var component = (DraggingStartComponent)CreateComponent(index, typeof(DraggingStartComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDraggingStart(Code.DraggingStartComponent newValue) {
        var index = GameComponentsLookup.DraggingStart;
        var component = (DraggingStartComponent)CreateComponent(index, typeof(DraggingStartComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDraggingStart() {
        RemoveComponent(GameComponentsLookup.DraggingStart);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDraggingStart;

    public static Entitas.IMatcher<GameEntity> DraggingStart {
        get {
            if (_matcherDraggingStart == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DraggingStart);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDraggingStart = matcher;
            }

            return _matcherDraggingStart;
        }
    }
}
