//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity configServiceEntity { get { return GetGroup(ServicesMatcher.ConfigService).GetSingleEntity(); } }
    public Code.ECS.Components.ConfigServiceComponent configService { get { return configServiceEntity.configService; } }
    public bool hasConfigService { get { return configServiceEntity != null; } }

    public ServicesEntity SetConfigService(Code.Services.Interfaces.IConfigService newValue) {
        if (hasConfigService) {
            throw new Entitas.EntitasException("Could not set ConfigService!\n" + this + " already has an entity with Code.ECS.Components.ConfigServiceComponent!",
                "You should check if the context already has a configServiceEntity before setting it or use context.ReplaceConfigService().");
        }
        var entity = CreateEntity();
        entity.AddConfigService(newValue);
        return entity;
    }

    public void ReplaceConfigService(Code.Services.Interfaces.IConfigService newValue) {
        var entity = configServiceEntity;
        if (entity == null) {
            entity = SetConfigService(newValue);
        } else {
            entity.ReplaceConfigService(newValue);
        }
    }

    public void RemoveConfigService() {
        configServiceEntity.Destroy();
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

    public Code.ECS.Components.ConfigServiceComponent configService { get { return (Code.ECS.Components.ConfigServiceComponent)GetComponent(ServicesComponentsLookup.ConfigService); } }
    public bool hasConfigService { get { return HasComponent(ServicesComponentsLookup.ConfigService); } }

    public void AddConfigService(Code.Services.Interfaces.IConfigService newValue) {
        var index = ServicesComponentsLookup.ConfigService;
        var component = (Code.ECS.Components.ConfigServiceComponent)CreateComponent(index, typeof(Code.ECS.Components.ConfigServiceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceConfigService(Code.Services.Interfaces.IConfigService newValue) {
        var index = ServicesComponentsLookup.ConfigService;
        var component = (Code.ECS.Components.ConfigServiceComponent)CreateComponent(index, typeof(Code.ECS.Components.ConfigServiceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveConfigService() {
        RemoveComponent(ServicesComponentsLookup.ConfigService);
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

    static Entitas.IMatcher<ServicesEntity> _matcherConfigService;

    public static Entitas.IMatcher<ServicesEntity> ConfigService {
        get {
            if (_matcherConfigService == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.ConfigService);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherConfigService = matcher;
            }

            return _matcherConfigService;
        }
    }
}
