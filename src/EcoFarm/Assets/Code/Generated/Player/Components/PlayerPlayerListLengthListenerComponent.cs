//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public PlayerListLengthListenerComponent playerListLengthListener { get { return (PlayerListLengthListenerComponent)GetComponent(PlayerComponentsLookup.PlayerListLengthListener); } }
    public bool hasPlayerListLengthListener { get { return HasComponent(PlayerComponentsLookup.PlayerListLengthListener); } }

    public void AddPlayerListLengthListener(System.Collections.Generic.List<IPlayerListLengthListener> newValue) {
        var index = PlayerComponentsLookup.PlayerListLengthListener;
        var component = (PlayerListLengthListenerComponent)CreateComponent(index, typeof(PlayerListLengthListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerListLengthListener(System.Collections.Generic.List<IPlayerListLengthListener> newValue) {
        var index = PlayerComponentsLookup.PlayerListLengthListener;
        var component = (PlayerListLengthListenerComponent)CreateComponent(index, typeof(PlayerListLengthListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerListLengthListener() {
        RemoveComponent(PlayerComponentsLookup.PlayerListLengthListener);
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

    static Entitas.IMatcher<PlayerEntity> _matcherPlayerListLengthListener;

    public static Entitas.IMatcher<PlayerEntity> PlayerListLengthListener {
        get {
            if (_matcherPlayerListLengthListener == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.PlayerListLengthListener);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherPlayerListLengthListener = matcher;
            }

            return _matcherPlayerListLengthListener;
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

    public void AddPlayerListLengthListener(IPlayerListLengthListener value) {
        var listeners = hasPlayerListLengthListener
            ? playerListLengthListener.value
            : new System.Collections.Generic.List<IPlayerListLengthListener>();
        listeners.Add(value);
        ReplacePlayerListLengthListener(listeners);
    }

    public void RemovePlayerListLengthListener(IPlayerListLengthListener value, bool removeComponentWhenEmpty = true) {
        var listeners = playerListLengthListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemovePlayerListLengthListener();
        } else {
            ReplacePlayerListLengthListener(listeners);
        }
    }
}