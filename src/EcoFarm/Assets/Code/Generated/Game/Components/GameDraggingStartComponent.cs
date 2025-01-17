//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.DraggingStartComponent draggingStart { get { return (EcoFarm.DraggingStartComponent)GetComponent(GameComponentsLookup.DraggingStart); } }
    public bool hasDraggingStart { get { return HasComponent(GameComponentsLookup.DraggingStart); } }

    public void AddDraggingStart(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.DraggingStart;
        var component = (EcoFarm.DraggingStartComponent)CreateComponent(index, typeof(EcoFarm.DraggingStartComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDraggingStart(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.DraggingStart;
        var component = (EcoFarm.DraggingStartComponent)CreateComponent(index, typeof(EcoFarm.DraggingStartComponent));
        component.Value = newValue;
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
