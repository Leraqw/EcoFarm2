//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public PlayerToEditListenerComponent playerToEditListener { get { return (PlayerToEditListenerComponent)GetComponent(PlayerComponentsLookup.PlayerToEditListener); } }
    public bool hasPlayerToEditListener { get { return HasComponent(PlayerComponentsLookup.PlayerToEditListener); } }

    public void AddPlayerToEditListener(System.Collections.Generic.List<IPlayerToEditListener> newValue) {
        var index = PlayerComponentsLookup.PlayerToEditListener;
        var component = (PlayerToEditListenerComponent)CreateComponent(index, typeof(PlayerToEditListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerToEditListener(System.Collections.Generic.List<IPlayerToEditListener> newValue) {
        var index = PlayerComponentsLookup.PlayerToEditListener;
        var component = (PlayerToEditListenerComponent)CreateComponent(index, typeof(PlayerToEditListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerToEditListener() {
        RemoveComponent(PlayerComponentsLookup.PlayerToEditListener);
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

    static Entitas.IMatcher<PlayerEntity> _matcherPlayerToEditListener;

    public static Entitas.IMatcher<PlayerEntity> PlayerToEditListener {
        get {
            if (_matcherPlayerToEditListener == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.PlayerToEditListener);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherPlayerToEditListener = matcher;
            }

            return _matcherPlayerToEditListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public void AddPlayerToEditListener(IPlayerToEditListener value) {
        var listeners = hasPlayerToEditListener
            ? playerToEditListener.value
            : new System.Collections.Generic.List<IPlayerToEditListener>();
        listeners.Add(value);
        ReplacePlayerToEditListener(listeners);
    }

    public void RemovePlayerToEditListener(IPlayerToEditListener value, bool removeComponentWhenEmpty = true) {
        var listeners = playerToEditListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemovePlayerToEditListener();
        } else {
            ReplacePlayerToEditListener(listeners);
        }
    }
}
