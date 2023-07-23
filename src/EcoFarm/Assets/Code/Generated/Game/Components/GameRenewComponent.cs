//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public RenewComponent renew { get { return (RenewComponent)GetComponent(GameComponentsLookup.Renew); } }
    public bool hasRenew { get { return HasComponent(GameComponentsLookup.Renew); } }

    public void AddRenew(Code.RenewComponent newValue) {
        var index = GameComponentsLookup.Renew;
        var component = (RenewComponent)CreateComponent(index, typeof(RenewComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRenew(Code.RenewComponent newValue) {
        var index = GameComponentsLookup.Renew;
        var component = (RenewComponent)CreateComponent(index, typeof(RenewComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRenew() {
        RemoveComponent(GameComponentsLookup.Renew);
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

    static Entitas.IMatcher<GameEntity> _matcherRenew;

    public static Entitas.IMatcher<GameEntity> Renew {
        get {
            if (_matcherRenew == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Renew);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRenew = matcher;
            }

            return _matcherRenew;
        }
    }
}
