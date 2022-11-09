//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.IntValueChangedComponent intValueChanged { get { return (Code.ECS.Components.IntValueChangedComponent)GetComponent(GameComponentsLookup.IntValueChanged); } }
    public bool hasIntValueChanged { get { return HasComponent(GameComponentsLookup.IntValueChanged); } }

    public void AddIntValueChanged(int newValue) {
        var index = GameComponentsLookup.IntValueChanged;
        var component = (Code.ECS.Components.IntValueChangedComponent)CreateComponent(index, typeof(Code.ECS.Components.IntValueChangedComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIntValueChanged(int newValue) {
        var index = GameComponentsLookup.IntValueChanged;
        var component = (Code.ECS.Components.IntValueChangedComponent)CreateComponent(index, typeof(Code.ECS.Components.IntValueChangedComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIntValueChanged() {
        RemoveComponent(GameComponentsLookup.IntValueChanged);
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

    static Entitas.IMatcher<GameEntity> _matcherIntValueChanged;

    public static Entitas.IMatcher<GameEntity> IntValueChanged {
        get {
            if (_matcherIntValueChanged == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.IntValueChanged);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIntValueChanged = matcher;
            }

            return _matcherIntValueChanged;
        }
    }
}
