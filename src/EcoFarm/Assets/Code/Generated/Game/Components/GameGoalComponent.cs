//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.GoalComponent goal { get { return (EcoFarm.GoalComponent)GetComponent(GameComponentsLookup.Goal); } }
    public bool hasGoal { get { return HasComponent(GameComponentsLookup.Goal); } }

    public void AddGoal(EcoFarmModel.Goal newValue) {
        var index = GameComponentsLookup.Goal;
        var component = (EcoFarm.GoalComponent)CreateComponent(index, typeof(EcoFarm.GoalComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoal(EcoFarmModel.Goal newValue) {
        var index = GameComponentsLookup.Goal;
        var component = (EcoFarm.GoalComponent)CreateComponent(index, typeof(EcoFarm.GoalComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoal() {
        RemoveComponent(GameComponentsLookup.Goal);
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

    static Entitas.IMatcher<GameEntity> _matcherGoal;

    public static Entitas.IMatcher<GameEntity> Goal {
        get {
            if (_matcherGoal == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Goal);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGoal = matcher;
            }

            return _matcherGoal;
        }
    }
}
