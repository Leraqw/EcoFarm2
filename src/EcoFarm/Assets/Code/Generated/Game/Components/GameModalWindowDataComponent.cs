//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity modalWindowDataEntity { get { return GetGroup(GameMatcher.ModalWindowData).GetSingleEntity(); } }
    public EcoFarm.ModalWindowDataComponent modalWindowData { get { return modalWindowDataEntity.modalWindowData; } }
    public bool hasModalWindowData { get { return modalWindowDataEntity != null; } }

    public GameEntity SetModalWindowData(string newTitle, string newMessage) {
        if (hasModalWindowData) {
            throw new Entitas.EntitasException("Could not set ModalWindowData!\n" + this + " already has an entity with EcoFarm.ModalWindowDataComponent!",
                "You should check if the context already has a modalWindowDataEntity before setting it or use context.ReplaceModalWindowData().");
        }
        var entity = CreateEntity();
        entity.AddModalWindowData(newTitle, newMessage);
        return entity;
    }

    public void ReplaceModalWindowData(string newTitle, string newMessage) {
        var entity = modalWindowDataEntity;
        if (entity == null) {
            entity = SetModalWindowData(newTitle, newMessage);
        } else {
            entity.ReplaceModalWindowData(newTitle, newMessage);
        }
    }

    public void RemoveModalWindowData() {
        modalWindowDataEntity.Destroy();
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

    public EcoFarm.ModalWindowDataComponent modalWindowData { get { return (EcoFarm.ModalWindowDataComponent)GetComponent(GameComponentsLookup.ModalWindowData); } }
    public bool hasModalWindowData { get { return HasComponent(GameComponentsLookup.ModalWindowData); } }

    public void AddModalWindowData(string newTitle, string newMessage) {
        var index = GameComponentsLookup.ModalWindowData;
        var component = (EcoFarm.ModalWindowDataComponent)CreateComponent(index, typeof(EcoFarm.ModalWindowDataComponent));
        component.Title = newTitle;
        component.Message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceModalWindowData(string newTitle, string newMessage) {
        var index = GameComponentsLookup.ModalWindowData;
        var component = (EcoFarm.ModalWindowDataComponent)CreateComponent(index, typeof(EcoFarm.ModalWindowDataComponent));
        component.Title = newTitle;
        component.Message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveModalWindowData() {
        RemoveComponent(GameComponentsLookup.ModalWindowData);
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

    static Entitas.IMatcher<GameEntity> _matcherModalWindowData;

    public static Entitas.IMatcher<GameEntity> ModalWindowData {
        get {
            if (_matcherModalWindowData == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ModalWindowData);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherModalWindowData = matcher;
            }

            return _matcherModalWindowData;
        }
    }
}
