//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SpawnPositionComponent spawnPosition { get { return (SpawnPositionComponent)GetComponent(GameComponentsLookup.SpawnPosition); } }
    public bool hasSpawnPosition { get { return HasComponent(GameComponentsLookup.SpawnPosition); } }

    public void AddSpawnPosition(Code.SpawnPositionComponent newValue) {
        var index = GameComponentsLookup.SpawnPosition;
        var component = (SpawnPositionComponent)CreateComponent(index, typeof(SpawnPositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSpawnPosition(Code.SpawnPositionComponent newValue) {
        var index = GameComponentsLookup.SpawnPosition;
        var component = (SpawnPositionComponent)CreateComponent(index, typeof(SpawnPositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSpawnPosition() {
        RemoveComponent(GameComponentsLookup.SpawnPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherSpawnPosition;

    public static Entitas.IMatcher<GameEntity> SpawnPosition {
        get {
            if (_matcherSpawnPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnPosition = matcher;
            }

            return _matcherSpawnPosition;
        }
    }
}
