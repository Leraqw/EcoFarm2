//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcoFarm.MouseUpComponent mouseUpComponent = new EcoFarm.MouseUpComponent();

    public bool isMouseUp {
        get { return HasComponent(GameComponentsLookup.MouseUp); }
        set {
            if (value != isMouseUp) {
                var index = GameComponentsLookup.MouseUp;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseUpComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherMouseUp;

    public static Entitas.IMatcher<GameEntity> MouseUp {
        get {
            if (_matcherMouseUp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MouseUp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMouseUp = matcher;
            }

            return _matcherMouseUp;
        }
    }
}
