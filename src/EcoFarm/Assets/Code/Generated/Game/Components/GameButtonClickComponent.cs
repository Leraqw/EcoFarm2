//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ButtonClickComponent buttonClick { get { return (ButtonClickComponent)GetComponent(GameComponentsLookup.ButtonClick); } }
    public bool hasButtonClick { get { return HasComponent(GameComponentsLookup.ButtonClick); } }

    public void AddButtonClick(Code.ButtonClickComponent newValue) {
        var index = GameComponentsLookup.ButtonClick;
        var component = (ButtonClickComponent)CreateComponent(index, typeof(ButtonClickComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceButtonClick(Code.ButtonClickComponent newValue) {
        var index = GameComponentsLookup.ButtonClick;
        var component = (ButtonClickComponent)CreateComponent(index, typeof(ButtonClickComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveButtonClick() {
        RemoveComponent(GameComponentsLookup.ButtonClick);
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

    static Entitas.IMatcher<GameEntity> _matcherButtonClick;

    public static Entitas.IMatcher<GameEntity> ButtonClick {
        get {
            if (_matcherButtonClick == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ButtonClick);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherButtonClick = matcher;
            }

            return _matcherButtonClick;
        }
    }
}
