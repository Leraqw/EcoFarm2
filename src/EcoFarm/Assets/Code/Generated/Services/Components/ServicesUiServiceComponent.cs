//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity uiServiceEntity { get { return GetGroup(ServicesMatcher.UiService).GetSingleEntity(); } }
    public Code.UiServiceComponent uiService { get { return uiServiceEntity.uiService; } }
    public bool hasUiService { get { return uiServiceEntity != null; } }

    public ServicesEntity SetUiService(Code.IUiService newValue) {
        if (hasUiService) {
            throw new Entitas.EntitasException("Could not set UiService!\n" + this + " already has an entity with Code.UiServiceComponent!",
                "You should check if the context already has a uiServiceEntity before setting it or use context.ReplaceUiService().");
        }
        var entity = CreateEntity();
        entity.AddUiService(newValue);
        return entity;
    }

    public void ReplaceUiService(Code.IUiService newValue) {
        var entity = uiServiceEntity;
        if (entity == null) {
            entity = SetUiService(newValue);
        } else {
            entity.ReplaceUiService(newValue);
        }
    }

    public void RemoveUiService() {
        uiServiceEntity.Destroy();
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
public partial class ServicesEntity {

    public Code.UiServiceComponent uiService { get { return (Code.UiServiceComponent)GetComponent(ServicesComponentsLookup.UiService); } }
    public bool hasUiService { get { return HasComponent(ServicesComponentsLookup.UiService); } }

    public void AddUiService(Code.IUiService newValue) {
        var index = ServicesComponentsLookup.UiService;
        var component = (Code.UiServiceComponent)CreateComponent(index, typeof(Code.UiServiceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUiService(Code.IUiService newValue) {
        var index = ServicesComponentsLookup.UiService;
        var component = (Code.UiServiceComponent)CreateComponent(index, typeof(Code.UiServiceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUiService() {
        RemoveComponent(ServicesComponentsLookup.UiService);
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
public sealed partial class ServicesMatcher {

    static Entitas.IMatcher<ServicesEntity> _matcherUiService;

    public static Entitas.IMatcher<ServicesEntity> UiService {
        get {
            if (_matcherUiService == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.UiService);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherUiService = matcher;
            }

            return _matcherUiService;
        }
    }
}
