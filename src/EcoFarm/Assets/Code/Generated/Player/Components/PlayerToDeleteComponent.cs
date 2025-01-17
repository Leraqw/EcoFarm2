//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerContext {

    public PlayerEntity toDeleteEntity { get { return GetGroup(PlayerMatcher.ToDelete).GetSingleEntity(); } }

    public bool isToDelete {
        get { return toDeleteEntity != null; }
        set {
            var entity = toDeleteEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isToDelete = true;
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
public partial class PlayerEntity {

    static readonly EcoFarm.ToDeleteComponent toDeleteComponent = new EcoFarm.ToDeleteComponent();

    public bool isToDelete {
        get { return HasComponent(PlayerComponentsLookup.ToDelete); }
        set {
            if (value != isToDelete) {
                var index = PlayerComponentsLookup.ToDelete;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : toDeleteComponent;

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
public sealed partial class PlayerMatcher {

    static Entitas.IMatcher<PlayerEntity> _matcherToDelete;

    public static Entitas.IMatcher<PlayerEntity> ToDelete {
        get {
            if (_matcherToDelete == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.ToDelete);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherToDelete = matcher;
            }

            return _matcherToDelete;
        }
    }
}
