//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public EcoFarm.EditedPlayerDataComponent editedPlayerData { get { return (EcoFarm.EditedPlayerDataComponent)GetComponent(PlayerComponentsLookup.EditedPlayerData); } }
    public bool hasEditedPlayerData { get { return HasComponent(PlayerComponentsLookup.EditedPlayerData); } }

    public void AddEditedPlayerData(EcoFarm.Player newValue) {
        var index = PlayerComponentsLookup.EditedPlayerData;
        var component = (EcoFarm.EditedPlayerDataComponent)CreateComponent(index, typeof(EcoFarm.EditedPlayerDataComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEditedPlayerData(EcoFarm.Player newValue) {
        var index = PlayerComponentsLookup.EditedPlayerData;
        var component = (EcoFarm.EditedPlayerDataComponent)CreateComponent(index, typeof(EcoFarm.EditedPlayerDataComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEditedPlayerData() {
        RemoveComponent(PlayerComponentsLookup.EditedPlayerData);
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

    static Entitas.IMatcher<PlayerEntity> _matcherEditedPlayerData;

    public static Entitas.IMatcher<PlayerEntity> EditedPlayerData {
        get {
            if (_matcherEditedPlayerData == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.EditedPlayerData);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherEditedPlayerData = matcher;
            }

            return _matcherEditedPlayerData;
        }
    }
}