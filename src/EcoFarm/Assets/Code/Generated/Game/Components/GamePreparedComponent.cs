//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.PreparedComponent preparedComponent = new Code.PreparedComponent();

    public bool isPrepared {
        get { return HasComponent(GameComponentsLookup.Prepared); }
        set {
            if (value != isPrepared) {
                var index = GameComponentsLookup.Prepared;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : preparedComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherPrepared;

    public static Entitas.IMatcher<GameEntity> Prepared {
        get {
            if (_matcherPrepared == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Prepared);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPrepared = matcher;
            }

            return _matcherPrepared;
        }
    }
}
