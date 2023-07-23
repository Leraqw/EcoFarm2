//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ActivateComponent activate { get { return (ActivateComponent)GetComponent(GameComponentsLookup.Activate); } }
    public bool hasActivate { get { return HasComponent(GameComponentsLookup.Activate); } }

    public void AddActivate(Code.ActivateComponent newValue) {
        var index = GameComponentsLookup.Activate;
        var component = (ActivateComponent)CreateComponent(index, typeof(ActivateComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceActivate(Code.ActivateComponent newValue) {
        var index = GameComponentsLookup.Activate;
        var component = (ActivateComponent)CreateComponent(index, typeof(ActivateComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveActivate() {
        RemoveComponent(GameComponentsLookup.Activate);
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

    static Entitas.IMatcher<GameEntity> _matcherActivate;

    public static Entitas.IMatcher<GameEntity> Activate {
        get {
            if (_matcherActivate == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Activate);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherActivate = matcher;
            }

            return _matcherActivate;
        }
    }
}
