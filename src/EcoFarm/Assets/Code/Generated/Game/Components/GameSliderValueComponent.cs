//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.SliderValueComponent sliderValue { get { return (Code.ECS.Components.SliderValueComponent)GetComponent(GameComponentsLookup.SliderValue); } }
    public bool hasSliderValue { get { return HasComponent(GameComponentsLookup.SliderValue); } }

    public void AddSliderValue(float newValue) {
        var index = GameComponentsLookup.SliderValue;
        var component = (Code.ECS.Components.SliderValueComponent)CreateComponent(index, typeof(Code.ECS.Components.SliderValueComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSliderValue(float newValue) {
        var index = GameComponentsLookup.SliderValue;
        var component = (Code.ECS.Components.SliderValueComponent)CreateComponent(index, typeof(Code.ECS.Components.SliderValueComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSliderValue() {
        RemoveComponent(GameComponentsLookup.SliderValue);
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

    static Entitas.IMatcher<GameEntity> _matcherSliderValue;

    public static Entitas.IMatcher<GameEntity> SliderValue {
        get {
            if (_matcherSliderValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SliderValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSliderValue = matcher;
            }

            return _matcherSliderValue;
        }
    }
}
