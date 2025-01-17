//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public EcoFarm.TextComponent text { get { return (EcoFarm.TextComponent)GetComponent(PlayerComponentsLookup.Text); } }
    public bool hasText { get { return HasComponent(PlayerComponentsLookup.Text); } }

    public void AddText(string newValue) {
        var index = PlayerComponentsLookup.Text;
        var component = (EcoFarm.TextComponent)CreateComponent(index, typeof(EcoFarm.TextComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceText(string newValue) {
        var index = PlayerComponentsLookup.Text;
        var component = (EcoFarm.TextComponent)CreateComponent(index, typeof(EcoFarm.TextComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveText() {
        RemoveComponent(PlayerComponentsLookup.Text);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity : ITextEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PlayerMatcher {

    static Entitas.IMatcher<PlayerEntity> _matcherText;

    public static Entitas.IMatcher<PlayerEntity> Text {
        get {
            if (_matcherText == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.Text);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherText = matcher;
            }

            return _matcherText;
        }
    }
}
