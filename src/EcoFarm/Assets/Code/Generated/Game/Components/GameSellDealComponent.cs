//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity sellDealEntity { get { return GetGroup(GameMatcher.SellDeal).GetSingleEntity(); } }

    public bool isSellDeal {
        get { return sellDealEntity != null; }
        set {
            var entity = sellDealEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isSellDeal = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.SellDealComponent sellDealComponent = new Code.SellDealComponent();

    public bool isSellDeal {
        get { return HasComponent(GameComponentsLookup.SellDeal); }
        set {
            if (value != isSellDeal) {
                var index = GameComponentsLookup.SellDeal;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sellDealComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherSellDeal;

    public static Entitas.IMatcher<GameEntity> SellDeal {
        get {
            if (_matcherSellDeal == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SellDeal);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSellDeal = matcher;
            }

            return _matcherSellDeal;
        }
    }
}
