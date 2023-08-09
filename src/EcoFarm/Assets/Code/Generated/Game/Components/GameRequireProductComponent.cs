//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.RequireProductComponent requireProduct { get { return (EcoFarm.RequireProductComponent)GetComponent(GameComponentsLookup.RequireProduct); } }
    public bool hasRequireProduct { get { return HasComponent(GameComponentsLookup.RequireProduct); } }

    public void AddRequireProduct(EcoFarm.ProductSO newValue) {
        var index = GameComponentsLookup.RequireProduct;
        var component = (EcoFarm.RequireProductComponent)CreateComponent(index, typeof(EcoFarm.RequireProductComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRequireProduct(EcoFarm.ProductSO newValue) {
        var index = GameComponentsLookup.RequireProduct;
        var component = (EcoFarm.RequireProductComponent)CreateComponent(index, typeof(EcoFarm.RequireProductComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRequireProduct() {
        RemoveComponent(GameComponentsLookup.RequireProduct);
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

    static Entitas.IMatcher<GameEntity> _matcherRequireProduct;

    public static Entitas.IMatcher<GameEntity> RequireProduct {
        get {
            if (_matcherRequireProduct == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RequireProduct);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRequireProduct = matcher;
            }

            return _matcherRequireProduct;
        }
    }
}
