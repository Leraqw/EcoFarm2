//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.FruitTypeIdComponent fruitTypeId { get { return (Code.ECS.Components.FruitTypeIdComponent)GetComponent(GameComponentsLookup.FruitTypeId); } }
    public bool hasFruitTypeId { get { return HasComponent(GameComponentsLookup.FruitTypeId); } }

    public void AddFruitTypeId(int newValue) {
        var index = GameComponentsLookup.FruitTypeId;
        var component = (Code.ECS.Components.FruitTypeIdComponent)CreateComponent(index, typeof(Code.ECS.Components.FruitTypeIdComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFruitTypeId(int newValue) {
        var index = GameComponentsLookup.FruitTypeId;
        var component = (Code.ECS.Components.FruitTypeIdComponent)CreateComponent(index, typeof(Code.ECS.Components.FruitTypeIdComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFruitTypeId() {
        RemoveComponent(GameComponentsLookup.FruitTypeId);
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

    static Entitas.IMatcher<GameEntity> _matcherFruitTypeId;

    public static Entitas.IMatcher<GameEntity> FruitTypeId {
        get {
            if (_matcherFruitTypeId == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FruitTypeId);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFruitTypeId = matcher;
            }

            return _matcherFruitTypeId;
        }
    }
}
