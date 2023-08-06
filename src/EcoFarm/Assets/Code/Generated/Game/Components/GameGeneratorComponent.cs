//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.GeneratorComponent generator { get { return (EcoFarm.GeneratorComponent)GetComponent(GameComponentsLookup.Generator); } }
    public bool hasGenerator { get { return HasComponent(GameComponentsLookup.Generator); } }

    public void AddGenerator(EcoFarmModel.Generator newValue) {
        var index = GameComponentsLookup.Generator;
        var component = (EcoFarm.GeneratorComponent)CreateComponent(index, typeof(EcoFarm.GeneratorComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGenerator(EcoFarmModel.Generator newValue) {
        var index = GameComponentsLookup.Generator;
        var component = (EcoFarm.GeneratorComponent)CreateComponent(index, typeof(EcoFarm.GeneratorComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGenerator() {
        RemoveComponent(GameComponentsLookup.Generator);
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

    static Entitas.IMatcher<GameEntity> _matcherGenerator;

    public static Entitas.IMatcher<GameEntity> Generator {
        get {
            if (_matcherGenerator == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Generator);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGenerator = matcher;
            }

            return _matcherGenerator;
        }
    }
}
