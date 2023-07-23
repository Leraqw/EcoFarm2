//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public DestroyComponent destroy { get { return (DestroyComponent)GetComponent(PlayerComponentsLookup.Destroy); } }
    public bool hasDestroy { get { return HasComponent(PlayerComponentsLookup.Destroy); } }

    public void AddDestroy(Code.DestroyComponent newValue) {
        var index = PlayerComponentsLookup.Destroy;
        var component = (DestroyComponent)CreateComponent(index, typeof(DestroyComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDestroy(Code.DestroyComponent newValue) {
        var index = PlayerComponentsLookup.Destroy;
        var component = (DestroyComponent)CreateComponent(index, typeof(DestroyComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDestroy() {
        RemoveComponent(PlayerComponentsLookup.Destroy);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity : IDestroyEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PlayerMatcher {

    static Entitas.IMatcher<PlayerEntity> _matcherDestroy;

    public static Entitas.IMatcher<PlayerEntity> Destroy {
        get {
            if (_matcherDestroy == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.Destroy);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherDestroy = matcher;
            }

            return _matcherDestroy;
        }
    }
}
