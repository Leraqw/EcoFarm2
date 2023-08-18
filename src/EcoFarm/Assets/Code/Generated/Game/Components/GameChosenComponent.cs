//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcoFarm.ChosenComponent chosenComponent = new EcoFarm.ChosenComponent();

    public bool isChosen {
        get { return HasComponent(GameComponentsLookup.Chosen); }
        set {
            if (value != isChosen) {
                var index = GameComponentsLookup.Chosen;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : chosenComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherChosen;

    public static Entitas.IMatcher<GameEntity> Chosen {
        get {
            if (_matcherChosen == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Chosen);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChosen = matcher;
            }

            return _matcherChosen;
        }
    }
}
