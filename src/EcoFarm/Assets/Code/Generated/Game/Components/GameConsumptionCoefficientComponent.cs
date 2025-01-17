//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.ConsumptionCoefficientComponent consumptionCoefficient { get { return (EcoFarm.ConsumptionCoefficientComponent)GetComponent(GameComponentsLookup.ConsumptionCoefficient); } }
    public bool hasConsumptionCoefficient { get { return HasComponent(GameComponentsLookup.ConsumptionCoefficient); } }

    public void AddConsumptionCoefficient(int newValue) {
        var index = GameComponentsLookup.ConsumptionCoefficient;
        var component = (EcoFarm.ConsumptionCoefficientComponent)CreateComponent(index, typeof(EcoFarm.ConsumptionCoefficientComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceConsumptionCoefficient(int newValue) {
        var index = GameComponentsLookup.ConsumptionCoefficient;
        var component = (EcoFarm.ConsumptionCoefficientComponent)CreateComponent(index, typeof(EcoFarm.ConsumptionCoefficientComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveConsumptionCoefficient() {
        RemoveComponent(GameComponentsLookup.ConsumptionCoefficient);
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

    static Entitas.IMatcher<GameEntity> _matcherConsumptionCoefficient;

    public static Entitas.IMatcher<GameEntity> ConsumptionCoefficient {
        get {
            if (_matcherConsumptionCoefficient == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ConsumptionCoefficient);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherConsumptionCoefficient = matcher;
            }

            return _matcherConsumptionCoefficient;
        }
    }
}
