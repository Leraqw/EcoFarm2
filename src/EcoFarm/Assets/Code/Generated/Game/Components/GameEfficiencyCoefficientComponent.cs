//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.EfficiencyCoefficientComponent efficiencyCoefficient { get { return (Code.EfficiencyCoefficientComponent)GetComponent(GameComponentsLookup.EfficiencyCoefficient); } }
    public bool hasEfficiencyCoefficient { get { return HasComponent(GameComponentsLookup.EfficiencyCoefficient); } }

    public void AddEfficiencyCoefficient(int newValue) {
        var index = GameComponentsLookup.EfficiencyCoefficient;
        var component = (Code.EfficiencyCoefficientComponent)CreateComponent(index, typeof(Code.EfficiencyCoefficientComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEfficiencyCoefficient(int newValue) {
        var index = GameComponentsLookup.EfficiencyCoefficient;
        var component = (Code.EfficiencyCoefficientComponent)CreateComponent(index, typeof(Code.EfficiencyCoefficientComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEfficiencyCoefficient() {
        RemoveComponent(GameComponentsLookup.EfficiencyCoefficient);
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

    static Entitas.IMatcher<GameEntity> _matcherEfficiencyCoefficient;

    public static Entitas.IMatcher<GameEntity> EfficiencyCoefficient {
        get {
            if (_matcherEfficiencyCoefficient == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EfficiencyCoefficient);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEfficiencyCoefficient = matcher;
            }

            return _matcherEfficiencyCoefficient;
        }
    }
}
