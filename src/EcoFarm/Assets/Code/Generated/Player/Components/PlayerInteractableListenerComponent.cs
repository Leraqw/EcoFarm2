//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public InteractableListenerComponent interactableListener { get { return (InteractableListenerComponent)GetComponent(PlayerComponentsLookup.InteractableListener); } }
    public bool hasInteractableListener { get { return HasComponent(PlayerComponentsLookup.InteractableListener); } }

    public void AddInteractableListener(System.Collections.Generic.List<IInteractableListener> newValue) {
        var index = PlayerComponentsLookup.InteractableListener;
        var component = (InteractableListenerComponent)CreateComponent(index, typeof(InteractableListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInteractableListener(System.Collections.Generic.List<IInteractableListener> newValue) {
        var index = PlayerComponentsLookup.InteractableListener;
        var component = (InteractableListenerComponent)CreateComponent(index, typeof(InteractableListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInteractableListener() {
        RemoveComponent(PlayerComponentsLookup.InteractableListener);
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

    static Entitas.IMatcher<PlayerEntity> _matcherInteractableListener;

    public static Entitas.IMatcher<PlayerEntity> InteractableListener {
        get {
            if (_matcherInteractableListener == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.InteractableListener);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherInteractableListener = matcher;
            }

            return _matcherInteractableListener;
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

    public void AddInteractableListener(IInteractableListener value) {
        var listeners = hasInteractableListener
            ? interactableListener.value
            : new System.Collections.Generic.List<IInteractableListener>();
        listeners.Add(value);
        ReplaceInteractableListener(listeners);
    }

    public void RemoveInteractableListener(IInteractableListener value, bool removeComponentWhenEmpty = true) {
        var listeners = interactableListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveInteractableListener();
        } else {
            ReplaceInteractableListener(listeners);
        }
    }
}
