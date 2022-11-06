//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.WateringComponent watering { get { return (Code.ECS.Components.WateringComponent)GetComponent(GameComponentsLookup.Watering); } }
    public bool hasWatering { get { return HasComponent(GameComponentsLookup.Watering); } }

    public void AddWatering(int newValue) {
        var index = GameComponentsLookup.Watering;
        var component = (Code.ECS.Components.WateringComponent)CreateComponent(index, typeof(Code.ECS.Components.WateringComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceWatering(int newValue) {
        var index = GameComponentsLookup.Watering;
        var component = (Code.ECS.Components.WateringComponent)CreateComponent(index, typeof(Code.ECS.Components.WateringComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveWatering() {
        RemoveComponent(GameComponentsLookup.Watering);
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

    static Entitas.IMatcher<GameEntity> _matcherWatering;

    public static Entitas.IMatcher<GameEntity> Watering {
        get {
            if (_matcherWatering == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Watering);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWatering = matcher;
            }

            return _matcherWatering;
        }
    }
}