//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.RenewPriceComponent renewPrice { get { return (Code.RenewPriceComponent)GetComponent(GameComponentsLookup.RenewPrice); } }
    public bool hasRenewPrice { get { return HasComponent(GameComponentsLookup.RenewPrice); } }

    public void AddRenewPrice(int newValue) {
        var index = GameComponentsLookup.RenewPrice;
        var component = (Code.RenewPriceComponent)CreateComponent(index, typeof(Code.RenewPriceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRenewPrice(int newValue) {
        var index = GameComponentsLookup.RenewPrice;
        var component = (Code.RenewPriceComponent)CreateComponent(index, typeof(Code.RenewPriceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRenewPrice() {
        RemoveComponent(GameComponentsLookup.RenewPrice);
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

    static Entitas.IMatcher<GameEntity> _matcherRenewPrice;

    public static Entitas.IMatcher<GameEntity> RenewPrice {
        get {
            if (_matcherRenewPrice == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RenewPrice);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRenewPrice = matcher;
            }

            return _matcherRenewPrice;
        }
    }
}
