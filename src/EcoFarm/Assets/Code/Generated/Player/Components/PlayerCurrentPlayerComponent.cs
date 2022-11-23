//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerContext {

    public PlayerEntity currentPlayerEntity { get { return GetGroup(PlayerMatcher.CurrentPlayer).GetSingleEntity(); } }

    public bool isCurrentPlayer {
        get { return currentPlayerEntity != null; }
        set {
            var entity = currentPlayerEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isCurrentPlayer = true;
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
public partial class PlayerEntity {

    static readonly Code.Global.PlayerContexts.Components.CurrentPlayerComponent currentPlayerComponent = new Code.Global.PlayerContexts.Components.CurrentPlayerComponent();

    public bool isCurrentPlayer {
        get { return HasComponent(PlayerComponentsLookup.CurrentPlayer); }
        set {
            if (value != isCurrentPlayer) {
                var index = PlayerComponentsLookup.CurrentPlayer;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : currentPlayerComponent;

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
public sealed partial class PlayerMatcher {

    static Entitas.IMatcher<PlayerEntity> _matcherCurrentPlayer;

    public static Entitas.IMatcher<PlayerEntity> CurrentPlayer {
        get {
            if (_matcherCurrentPlayer == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.CurrentPlayer);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherCurrentPlayer = matcher;
            }

            return _matcherCurrentPlayer;
        }
    }
}
