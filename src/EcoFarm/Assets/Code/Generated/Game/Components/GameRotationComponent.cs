//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.RotationComponent rotation { get { return (Code.RotationComponent)GetComponent(GameComponentsLookup.Rotation); } }
    public bool hasRotation { get { return HasComponent(GameComponentsLookup.Rotation); } }

    public void AddRotation(float newValue) {
        var index = GameComponentsLookup.Rotation;
        var component = (Code.RotationComponent)CreateComponent(index, typeof(Code.RotationComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRotation(float newValue) {
        var index = GameComponentsLookup.Rotation;
        var component = (Code.RotationComponent)CreateComponent(index, typeof(Code.RotationComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRotation() {
        RemoveComponent(GameComponentsLookup.Rotation);
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

    static Entitas.IMatcher<GameEntity> _matcherRotation;

    public static Entitas.IMatcher<GameEntity> Rotation {
        get {
            if (_matcherRotation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Rotation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRotation = matcher;
            }

            return _matcherRotation;
        }
    }
}
