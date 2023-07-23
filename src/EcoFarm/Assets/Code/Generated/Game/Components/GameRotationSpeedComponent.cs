//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.RotationSpeedComponent rotationSpeed { get { return (Code.RotationSpeedComponent)GetComponent(GameComponentsLookup.RotationSpeed); } }
    public bool hasRotationSpeed { get { return HasComponent(GameComponentsLookup.RotationSpeed); } }

    public void AddRotationSpeed(float newValue) {
        var index = GameComponentsLookup.RotationSpeed;
        var component = (Code.RotationSpeedComponent)CreateComponent(index, typeof(Code.RotationSpeedComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRotationSpeed(float newValue) {
        var index = GameComponentsLookup.RotationSpeed;
        var component = (Code.RotationSpeedComponent)CreateComponent(index, typeof(Code.RotationSpeedComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRotationSpeed() {
        RemoveComponent(GameComponentsLookup.RotationSpeed);
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

    static Entitas.IMatcher<GameEntity> _matcherRotationSpeed;

    public static Entitas.IMatcher<GameEntity> RotationSpeed {
        get {
            if (_matcherRotationSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RotationSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRotationSpeed = matcher;
            }

            return _matcherRotationSpeed;
        }
    }
}
