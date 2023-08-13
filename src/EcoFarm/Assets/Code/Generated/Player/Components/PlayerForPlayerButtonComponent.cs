//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    static readonly EcoFarm.ForPlayerButtonComponent forPlayerButtonComponent = new EcoFarm.ForPlayerButtonComponent();

    public bool isForPlayerButton {
        get { return HasComponent(PlayerComponentsLookup.ForPlayerButton); }
        set {
            if (value != isForPlayerButton) {
                var index = PlayerComponentsLookup.ForPlayerButton;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : forPlayerButtonComponent;

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

    static Entitas.IMatcher<PlayerEntity> _matcherForPlayerButton;

    public static Entitas.IMatcher<PlayerEntity> ForPlayerButton {
        get {
            if (_matcherForPlayerButton == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.ForPlayerButton);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherForPlayerButton = matcher;
            }

            return _matcherForPlayerButton;
        }
    }
}
