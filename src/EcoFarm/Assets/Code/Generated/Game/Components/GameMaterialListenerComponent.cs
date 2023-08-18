//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MaterialListenerComponent materialListener { get { return (MaterialListenerComponent)GetComponent(GameComponentsLookup.MaterialListener); } }
    public bool hasMaterialListener { get { return HasComponent(GameComponentsLookup.MaterialListener); } }

    public void AddMaterialListener(System.Collections.Generic.List<IMaterialListener> newValue) {
        var index = GameComponentsLookup.MaterialListener;
        var component = (MaterialListenerComponent)CreateComponent(index, typeof(MaterialListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMaterialListener(System.Collections.Generic.List<IMaterialListener> newValue) {
        var index = GameComponentsLookup.MaterialListener;
        var component = (MaterialListenerComponent)CreateComponent(index, typeof(MaterialListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMaterialListener() {
        RemoveComponent(GameComponentsLookup.MaterialListener);
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

    static Entitas.IMatcher<GameEntity> _matcherMaterialListener;

    public static Entitas.IMatcher<GameEntity> MaterialListener {
        get {
            if (_matcherMaterialListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MaterialListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMaterialListener = matcher;
            }

            return _matcherMaterialListener;
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

    public void AddMaterialListener(IMaterialListener value) {
        var listeners = hasMaterialListener
            ? materialListener.value
            : new System.Collections.Generic.List<IMaterialListener>();
        listeners.Add(value);
        ReplaceMaterialListener(listeners);
    }

    public void RemoveMaterialListener(IMaterialListener value, bool removeComponentWhenEmpty = true) {
        var listeners = materialListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveMaterialListener();
        } else {
            ReplaceMaterialListener(listeners);
        }
    }
}
