//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public EditModeListenerComponent editModeListener { get { return (EditModeListenerComponent)GetComponent(PlayerComponentsLookup.EditModeListener); } }
    public bool hasEditModeListener { get { return HasComponent(PlayerComponentsLookup.EditModeListener); } }

    public void AddEditModeListener(System.Collections.Generic.List<IEditModeListener> newValue) {
        var index = PlayerComponentsLookup.EditModeListener;
        var component = (EditModeListenerComponent)CreateComponent(index, typeof(EditModeListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEditModeListener(System.Collections.Generic.List<IEditModeListener> newValue) {
        var index = PlayerComponentsLookup.EditModeListener;
        var component = (EditModeListenerComponent)CreateComponent(index, typeof(EditModeListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEditModeListener() {
        RemoveComponent(PlayerComponentsLookup.EditModeListener);
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

    static Entitas.IMatcher<PlayerEntity> _matcherEditModeListener;

    public static Entitas.IMatcher<PlayerEntity> EditModeListener {
        get {
            if (_matcherEditModeListener == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.EditModeListener);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherEditModeListener = matcher;
            }

            return _matcherEditModeListener;
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

    public void AddEditModeListener(IEditModeListener value) {
        var listeners = hasEditModeListener
            ? editModeListener.value
            : new System.Collections.Generic.List<IEditModeListener>();
        listeners.Add(value);
        ReplaceEditModeListener(listeners);
    }

    public void RemoveEditModeListener(IEditModeListener value, bool removeComponentWhenEmpty = true) {
        var listeners = editModeListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveEditModeListener();
        } else {
            ReplaceEditModeListener(listeners);
        }
    }
}
