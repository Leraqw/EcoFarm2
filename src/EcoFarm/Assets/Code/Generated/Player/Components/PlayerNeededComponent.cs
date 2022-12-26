//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    static readonly Code.Temp.NeededComponent neededComponent = new Code.Temp.NeededComponent();

    public bool isNeeded {
        get { return HasComponent(PlayerComponentsLookup.Needed); }
        set {
            if (value != isNeeded) {
                var index = PlayerComponentsLookup.Needed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : neededComponent;

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

    static Entitas.IMatcher<PlayerEntity> _matcherNeeded;

    public static Entitas.IMatcher<PlayerEntity> Needed {
        get {
            if (_matcherNeeded == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.Needed);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherNeeded = matcher;
            }

            return _matcherNeeded;
        }
    }
}
