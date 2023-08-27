//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public EcoFarm.PlayerListLengthComponent playerListLength { get { return (EcoFarm.PlayerListLengthComponent)GetComponent(PlayerComponentsLookup.PlayerListLength); } }
    public bool hasPlayerListLength { get { return HasComponent(PlayerComponentsLookup.PlayerListLength); } }

    public void AddPlayerListLength(int newValue) {
        var index = PlayerComponentsLookup.PlayerListLength;
        var component = (EcoFarm.PlayerListLengthComponent)CreateComponent(index, typeof(EcoFarm.PlayerListLengthComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePlayerListLength(int newValue) {
        var index = PlayerComponentsLookup.PlayerListLength;
        var component = (EcoFarm.PlayerListLengthComponent)CreateComponent(index, typeof(EcoFarm.PlayerListLengthComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerListLength() {
        RemoveComponent(PlayerComponentsLookup.PlayerListLength);
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

    static Entitas.IMatcher<PlayerEntity> _matcherPlayerListLength;

    public static Entitas.IMatcher<PlayerEntity> PlayerListLength {
        get {
            if (_matcherPlayerListLength == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.PlayerListLength);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherPlayerListLength = matcher;
            }

            return _matcherPlayerListLength;
        }
    }
}
