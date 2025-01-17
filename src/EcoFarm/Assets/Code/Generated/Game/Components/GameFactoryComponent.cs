//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.FactoryComponent factory { get { return (EcoFarm.FactoryComponent)GetComponent(GameComponentsLookup.Factory); } }
    public bool hasFactory { get { return HasComponent(GameComponentsLookup.Factory); } }

    public void AddFactory(EcoFarm.Factory newValue) {
        var index = GameComponentsLookup.Factory;
        var component = (EcoFarm.FactoryComponent)CreateComponent(index, typeof(EcoFarm.FactoryComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFactory(EcoFarm.Factory newValue) {
        var index = GameComponentsLookup.Factory;
        var component = (EcoFarm.FactoryComponent)CreateComponent(index, typeof(EcoFarm.FactoryComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFactory() {
        RemoveComponent(GameComponentsLookup.Factory);
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

    static Entitas.IMatcher<GameEntity> _matcherFactory;

    public static Entitas.IMatcher<GameEntity> Factory {
        get {
            if (_matcherFactory == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Factory);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFactory = matcher;
            }

            return _matcherFactory;
        }
    }
}
