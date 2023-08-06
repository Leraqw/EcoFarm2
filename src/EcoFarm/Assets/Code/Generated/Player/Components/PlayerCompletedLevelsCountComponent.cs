//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public EcoFarm.CompletedLevelsCountComponent completedLevelsCount { get { return (EcoFarm.CompletedLevelsCountComponent)GetComponent(PlayerComponentsLookup.CompletedLevelsCount); } }
    public bool hasCompletedLevelsCount { get { return HasComponent(PlayerComponentsLookup.CompletedLevelsCount); } }

    public void AddCompletedLevelsCount(int newValue) {
        var index = PlayerComponentsLookup.CompletedLevelsCount;
        var component = (EcoFarm.CompletedLevelsCountComponent)CreateComponent(index, typeof(EcoFarm.CompletedLevelsCountComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCompletedLevelsCount(int newValue) {
        var index = PlayerComponentsLookup.CompletedLevelsCount;
        var component = (EcoFarm.CompletedLevelsCountComponent)CreateComponent(index, typeof(EcoFarm.CompletedLevelsCountComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCompletedLevelsCount() {
        RemoveComponent(PlayerComponentsLookup.CompletedLevelsCount);
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

    static Entitas.IMatcher<PlayerEntity> _matcherCompletedLevelsCount;

    public static Entitas.IMatcher<PlayerEntity> CompletedLevelsCount {
        get {
            if (_matcherCompletedLevelsCount == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.CompletedLevelsCount);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherCompletedLevelsCount = matcher;
            }

            return _matcherCompletedLevelsCount;
        }
    }
}
