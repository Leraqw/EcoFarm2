//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DestroyComponent destroy { get { return (DestroyComponent)GetComponent(GameComponentsLookup.Destroy); } }
    public bool hasDestroy { get { return HasComponent(GameComponentsLookup.Destroy); } }

    public void AddDestroy(Code.DestroyComponent newValue) {
        var index = GameComponentsLookup.Destroy;
        var component = (DestroyComponent)CreateComponent(index, typeof(DestroyComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDestroy(Code.DestroyComponent newValue) {
        var index = GameComponentsLookup.Destroy;
        var component = (DestroyComponent)CreateComponent(index, typeof(DestroyComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDestroy() {
        RemoveComponent(GameComponentsLookup.Destroy);
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
public partial class GameEntity : IDestroyEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDestroy;

    public static Entitas.IMatcher<GameEntity> Destroy {
        get {
            if (_matcherDestroy == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Destroy);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDestroy = matcher;
            }

            return _matcherDestroy;
        }
    }
}
