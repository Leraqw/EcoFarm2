//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity playerChoiceWindowEntity { get { return GetGroup(GameMatcher.PlayerChoiceWindow).GetSingleEntity(); } }

    public bool isPlayerChoiceWindow {
        get { return playerChoiceWindowEntity != null; }
        set {
            var entity = playerChoiceWindowEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isPlayerChoiceWindow = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly EcoFarm.PlayerChoiceWindowComponent playerChoiceWindowComponent = new EcoFarm.PlayerChoiceWindowComponent();

    public bool isPlayerChoiceWindow {
        get { return HasComponent(GameComponentsLookup.PlayerChoiceWindow); }
        set {
            if (value != isPlayerChoiceWindow) {
                var index = GameComponentsLookup.PlayerChoiceWindow;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : playerChoiceWindowComponent;

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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerChoiceWindow;

    public static Entitas.IMatcher<GameEntity> PlayerChoiceWindow {
        get {
            if (_matcherPlayerChoiceWindow == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerChoiceWindow);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerChoiceWindow = matcher;
            }

            return _matcherPlayerChoiceWindow;
        }
    }
}
