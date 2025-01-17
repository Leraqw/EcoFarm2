//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.BuildingComponent building { get { return (EcoFarm.BuildingComponent)GetComponent(GameComponentsLookup.Building); } }
    public bool hasBuilding { get { return HasComponent(GameComponentsLookup.Building); } }

    public void AddBuilding(EcoFarm.Building newValue) {
        var index = GameComponentsLookup.Building;
        var component = (EcoFarm.BuildingComponent)CreateComponent(index, typeof(EcoFarm.BuildingComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBuilding(EcoFarm.Building newValue) {
        var index = GameComponentsLookup.Building;
        var component = (EcoFarm.BuildingComponent)CreateComponent(index, typeof(EcoFarm.BuildingComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBuilding() {
        RemoveComponent(GameComponentsLookup.Building);
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

    static Entitas.IMatcher<GameEntity> _matcherBuilding;

    public static Entitas.IMatcher<GameEntity> Building {
        get {
            if (_matcherBuilding == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Building);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBuilding = matcher;
            }

            return _matcherBuilding;
        }
    }
}
