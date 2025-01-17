//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EcoFarm.MaterialComponent material { get { return (EcoFarm.MaterialComponent)GetComponent(GameComponentsLookup.Material); } }
    public bool hasMaterial { get { return HasComponent(GameComponentsLookup.Material); } }

    public void AddMaterial(UnityEngine.Material newValue) {
        var index = GameComponentsLookup.Material;
        var component = (EcoFarm.MaterialComponent)CreateComponent(index, typeof(EcoFarm.MaterialComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMaterial(UnityEngine.Material newValue) {
        var index = GameComponentsLookup.Material;
        var component = (EcoFarm.MaterialComponent)CreateComponent(index, typeof(EcoFarm.MaterialComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMaterial() {
        RemoveComponent(GameComponentsLookup.Material);
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

    static Entitas.IMatcher<GameEntity> _matcherMaterial;

    public static Entitas.IMatcher<GameEntity> Material {
        get {
            if (_matcherMaterial == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Material);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMaterial = matcher;
            }

            return _matcherMaterial;
        }
    }
}
