//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.CoinsCountComponent coinsCount { get { return (Code.CoinsCountComponent)GetComponent(GameComponentsLookup.CoinsCount); } }
    public bool hasCoinsCount { get { return HasComponent(GameComponentsLookup.CoinsCount); } }

    public void AddCoinsCount(int newValue) {
        var index = GameComponentsLookup.CoinsCount;
        var component = (Code.CoinsCountComponent)CreateComponent(index, typeof(Code.CoinsCountComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCoinsCount(int newValue) {
        var index = GameComponentsLookup.CoinsCount;
        var component = (Code.CoinsCountComponent)CreateComponent(index, typeof(Code.CoinsCountComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCoinsCount() {
        RemoveComponent(GameComponentsLookup.CoinsCount);
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

    static Entitas.IMatcher<GameEntity> _matcherCoinsCount;

    public static Entitas.IMatcher<GameEntity> CoinsCount {
        get {
            if (_matcherCoinsCount == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CoinsCount);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCoinsCount = matcher;
            }

            return _matcherCoinsCount;
        }
    }
}
