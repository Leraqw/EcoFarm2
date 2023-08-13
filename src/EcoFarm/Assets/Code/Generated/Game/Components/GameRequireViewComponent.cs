//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.RequireViewComponent requireView { get { return (EcoFarm.RequireViewComponent)GetComponent(GameComponentsLookup.RequireView); } }
    public bool hasRequireView { get { return HasComponent(GameComponentsLookup.RequireView); } }

    public void AddRequireView(string newValue) {
        var index = GameComponentsLookup.RequireView;
        var component = (EcoFarm.RequireViewComponent)CreateComponent(index, typeof(EcoFarm.RequireViewComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRequireView(string newValue) {
        var index = GameComponentsLookup.RequireView;
        var component = (EcoFarm.RequireViewComponent)CreateComponent(index, typeof(EcoFarm.RequireViewComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRequireView() {
        RemoveComponent(GameComponentsLookup.RequireView);
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

    static Entitas.IMatcher<GameEntity> _matcherRequireView;

    public static Entitas.IMatcher<GameEntity> RequireView {
        get {
            if (_matcherRequireView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RequireView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRequireView = matcher;
            }

            return _matcherRequireView;
        }
    }
}
