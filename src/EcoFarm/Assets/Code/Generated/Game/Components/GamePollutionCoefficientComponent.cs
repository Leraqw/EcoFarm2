//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PollutionCoefficientComponent pollutionCoefficient { get { return (PollutionCoefficientComponent)GetComponent(GameComponentsLookup.PollutionCoefficient); } }
    public bool hasPollutionCoefficient { get { return HasComponent(GameComponentsLookup.PollutionCoefficient); } }

    public void AddPollutionCoefficient(Code.PollutionCoefficientComponent newValue) {
        var index = GameComponentsLookup.PollutionCoefficient;
        var component = (PollutionCoefficientComponent)CreateComponent(index, typeof(PollutionCoefficientComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePollutionCoefficient(Code.PollutionCoefficientComponent newValue) {
        var index = GameComponentsLookup.PollutionCoefficient;
        var component = (PollutionCoefficientComponent)CreateComponent(index, typeof(PollutionCoefficientComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePollutionCoefficient() {
        RemoveComponent(GameComponentsLookup.PollutionCoefficient);
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

    static Entitas.IMatcher<GameEntity> _matcherPollutionCoefficient;

    public static Entitas.IMatcher<GameEntity> PollutionCoefficient {
        get {
            if (_matcherPollutionCoefficient == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PollutionCoefficient);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPollutionCoefficient = matcher;
            }

            return _matcherPollutionCoefficient;
        }
    }
}
