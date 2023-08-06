//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcoFarm.PickedComponent pickedComponent = new EcoFarm.PickedComponent();

    public bool isPicked {
        get { return HasComponent(GameComponentsLookup.Picked); }
        set {
            if (value != isPicked) {
                var index = GameComponentsLookup.Picked;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : pickedComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherPicked;

    public static Entitas.IMatcher<GameEntity> Picked {
        get {
            if (_matcherPicked == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Picked);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPicked = matcher;
            }

            return _matcherPicked;
        }
    }
}
