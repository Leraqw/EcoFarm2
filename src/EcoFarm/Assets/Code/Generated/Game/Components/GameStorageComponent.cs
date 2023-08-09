//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity storageEntity { get { return GetGroup(GameMatcher.Storage).GetSingleEntity(); } }
    public EcoFarm.StorageComponent storage { get { return storageEntity.storage; } }
    public bool hasStorage { get { return storageEntity != null; } }

    public GameEntity SetStorage(EcoFarm.StorageSO newValue) {
        if (hasStorage) {
            throw new Entitas.EntitasException("Could not set Storage!\n" + this + " already has an entity with EcoFarm.StorageComponent!",
                "You should check if the context already has a storageEntity before setting it or use context.ReplaceStorage().");
        }
        var entity = CreateEntity();
        entity.AddStorage(newValue);
        return entity;
    }

    public void ReplaceStorage(EcoFarm.StorageSO newValue) {
        var entity = storageEntity;
        if (entity == null) {
            entity = SetStorage(newValue);
        } else {
            entity.ReplaceStorage(newValue);
        }
    }

    public void RemoveStorage() {
        storageEntity.Destroy();
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

    public EcoFarm.StorageComponent storage { get { return (EcoFarm.StorageComponent)GetComponent(GameComponentsLookup.Storage); } }
    public bool hasStorage { get { return HasComponent(GameComponentsLookup.Storage); } }

    public void AddStorage(EcoFarm.StorageSO newValue) {
        var index = GameComponentsLookup.Storage;
        var component = (EcoFarm.StorageComponent)CreateComponent(index, typeof(EcoFarm.StorageComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStorage(EcoFarm.StorageSO newValue) {
        var index = GameComponentsLookup.Storage;
        var component = (EcoFarm.StorageComponent)CreateComponent(index, typeof(EcoFarm.StorageComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStorage() {
        RemoveComponent(GameComponentsLookup.Storage);
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

    static Entitas.IMatcher<GameEntity> _matcherStorage;

    public static Entitas.IMatcher<GameEntity> Storage {
        get {
            if (_matcherStorage == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Storage);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStorage = matcher;
            }

            return _matcherStorage;
        }
    }
}
