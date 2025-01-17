//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ModalWindowDataListenerComponent modalWindowDataListener { get { return (ModalWindowDataListenerComponent)GetComponent(GameComponentsLookup.ModalWindowDataListener); } }
    public bool hasModalWindowDataListener { get { return HasComponent(GameComponentsLookup.ModalWindowDataListener); } }

    public void AddModalWindowDataListener(System.Collections.Generic.List<IModalWindowDataListener> newValue) {
        var index = GameComponentsLookup.ModalWindowDataListener;
        var component = (ModalWindowDataListenerComponent)CreateComponent(index, typeof(ModalWindowDataListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceModalWindowDataListener(System.Collections.Generic.List<IModalWindowDataListener> newValue) {
        var index = GameComponentsLookup.ModalWindowDataListener;
        var component = (ModalWindowDataListenerComponent)CreateComponent(index, typeof(ModalWindowDataListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveModalWindowDataListener() {
        RemoveComponent(GameComponentsLookup.ModalWindowDataListener);
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

    static Entitas.IMatcher<GameEntity> _matcherModalWindowDataListener;

    public static Entitas.IMatcher<GameEntity> ModalWindowDataListener {
        get {
            if (_matcherModalWindowDataListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ModalWindowDataListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherModalWindowDataListener = matcher;
            }

            return _matcherModalWindowDataListener;
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

    public void AddModalWindowDataListener(IModalWindowDataListener value) {
        var listeners = hasModalWindowDataListener
            ? modalWindowDataListener.value
            : new System.Collections.Generic.List<IModalWindowDataListener>();
        listeners.Add(value);
        ReplaceModalWindowDataListener(listeners);
    }

    public void RemoveModalWindowDataListener(IModalWindowDataListener value, bool removeComponentWhenEmpty = true) {
        var listeners = modalWindowDataListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveModalWindowDataListener();
        } else {
            ReplaceModalWindowDataListener(listeners);
        }
    }
}
