//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity inventoryEntity { get { return GetGroup(GameMatcher.Inventory).GetSingleEntity(); } }

    public bool isInventory {
        get { return inventoryEntity != null; }
        set {
            var entity = inventoryEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isInventory = true;
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

    static readonly EcoFarm.InventoryComponent inventoryComponent = new EcoFarm.InventoryComponent();

    public bool isInventory {
        get { return HasComponent(GameComponentsLookup.Inventory); }
        set {
            if (value != isInventory) {
                var index = GameComponentsLookup.Inventory;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : inventoryComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherInventory;

    public static Entitas.IMatcher<GameEntity> Inventory {
        get {
            if (_matcherInventory == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Inventory);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInventory = matcher;
            }

            return _matcherInventory;
        }
    }
}
