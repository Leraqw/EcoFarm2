//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.TargetPositionComponent targetPosition { get { return (EcoFarm.TargetPositionComponent)GetComponent(GameComponentsLookup.TargetPosition); } }
    public bool hasTargetPosition { get { return HasComponent(GameComponentsLookup.TargetPosition); } }

    public void AddTargetPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.TargetPosition;
        var component = (EcoFarm.TargetPositionComponent)CreateComponent(index, typeof(EcoFarm.TargetPositionComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTargetPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.TargetPosition;
        var component = (EcoFarm.TargetPositionComponent)CreateComponent(index, typeof(EcoFarm.TargetPositionComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTargetPosition() {
        RemoveComponent(GameComponentsLookup.TargetPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherTargetPosition;

    public static Entitas.IMatcher<GameEntity> TargetPosition {
        get {
            if (_matcherTargetPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TargetPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTargetPosition = matcher;
            }

            return _matcherTargetPosition;
        }
    }
}
