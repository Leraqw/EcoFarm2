//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public WateringListenerComponent wateringListener { get { return (WateringListenerComponent)GetComponent(GameComponentsLookup.WateringListener); } }
    public bool hasWateringListener { get { return HasComponent(GameComponentsLookup.WateringListener); } }

    public void AddWateringListener(System.Collections.Generic.List<IWateringListener> newValue) {
        var index = GameComponentsLookup.WateringListener;
        var component = (WateringListenerComponent)CreateComponent(index, typeof(WateringListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceWateringListener(System.Collections.Generic.List<IWateringListener> newValue) {
        var index = GameComponentsLookup.WateringListener;
        var component = (WateringListenerComponent)CreateComponent(index, typeof(WateringListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveWateringListener() {
        RemoveComponent(GameComponentsLookup.WateringListener);
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

    static Entitas.IMatcher<GameEntity> _matcherWateringListener;

    public static Entitas.IMatcher<GameEntity> WateringListener {
        get {
            if (_matcherWateringListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WateringListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWateringListener = matcher;
            }

            return _matcherWateringListener;
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
public partial class GameEntity {

    public void AddWateringListener(IWateringListener value) {
        var listeners = hasWateringListener
            ? wateringListener.value
            : new System.Collections.Generic.List<IWateringListener>();
        listeners.Add(value);
        ReplaceWateringListener(listeners);
    }

    public void RemoveWateringListener(IWateringListener value, bool removeComponentWhenEmpty = true) {
        var listeners = wateringListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveWateringListener();
        } else {
            ReplaceWateringListener(listeners);
        }
    }
}