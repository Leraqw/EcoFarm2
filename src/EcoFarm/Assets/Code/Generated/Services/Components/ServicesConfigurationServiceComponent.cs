//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity configurationServiceEntity { get { return GetGroup(ServicesMatcher.ConfigurationService).GetSingleEntity(); } }
    public EcoFarm.ConfigurationServiceComponent configurationService { get { return configurationServiceEntity.configurationService; } }
    public bool hasConfigurationService { get { return configurationServiceEntity != null; } }

    public ServicesEntity SetConfigurationService(EcoFarm.IConfigurationService newValue) {
        if (hasConfigurationService) {
            throw new Entitas.EntitasException("Could not set ConfigurationService!\n" + this + " already has an entity with EcoFarm.ConfigurationServiceComponent!",
                "You should check if the context already has a configurationServiceEntity before setting it or use context.ReplaceConfigurationService().");
        }
        var entity = CreateEntity();
        entity.AddConfigurationService(newValue);
        return entity;
    }

    public void ReplaceConfigurationService(EcoFarm.IConfigurationService newValue) {
        var entity = configurationServiceEntity;
        if (entity == null) {
            entity = SetConfigurationService(newValue);
        } else {
            entity.ReplaceConfigurationService(newValue);
        }
    }

    public void RemoveConfigurationService() {
        configurationServiceEntity.Destroy();
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

    public EcoFarm.ConfigurationServiceComponent configurationService { get { return (EcoFarm.ConfigurationServiceComponent)GetComponent(ServicesComponentsLookup.ConfigurationService); } }
    public bool hasConfigurationService { get { return HasComponent(ServicesComponentsLookup.ConfigurationService); } }

    public void AddConfigurationService(EcoFarm.IConfigurationService newValue) {
        var index = ServicesComponentsLookup.ConfigurationService;
        var component = (EcoFarm.ConfigurationServiceComponent)CreateComponent(index, typeof(EcoFarm.ConfigurationServiceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceConfigurationService(EcoFarm.IConfigurationService newValue) {
        var index = ServicesComponentsLookup.ConfigurationService;
        var component = (EcoFarm.ConfigurationServiceComponent)CreateComponent(index, typeof(EcoFarm.ConfigurationServiceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveConfigurationService() {
        RemoveComponent(ServicesComponentsLookup.ConfigurationService);
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

    static Entitas.IMatcher<ServicesEntity> _matcherConfigurationService;

    public static Entitas.IMatcher<ServicesEntity> ConfigurationService {
        get {
            if (_matcherConfigurationService == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.ConfigurationService);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherConfigurationService = matcher;
            }

            return _matcherConfigurationService;
        }
    }
}
