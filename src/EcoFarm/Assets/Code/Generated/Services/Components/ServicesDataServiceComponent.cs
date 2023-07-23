//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity dataServiceEntity { get { return GetGroup(ServicesMatcher.DataService).GetSingleEntity(); } }
    public Code.DataServiceComponent dataService { get { return dataServiceEntity.dataService; } }
    public bool hasDataService { get { return dataServiceEntity != null; } }

    public ServicesEntity SetDataService(Code.IDataService newValue) {
        if (hasDataService) {
            throw new Entitas.EntitasException("Could not set DataService!\n" + this + " already has an entity with Code.DataServiceComponent!",
                "You should check if the context already has a dataServiceEntity before setting it or use context.ReplaceDataService().");
        }
        var entity = CreateEntity();
        entity.AddDataService(newValue);
        return entity;
    }

    public void ReplaceDataService(Code.IDataService newValue) {
        var entity = dataServiceEntity;
        if (entity == null) {
            entity = SetDataService(newValue);
        } else {
            entity.ReplaceDataService(newValue);
        }
    }

    public void RemoveDataService() {
        dataServiceEntity.Destroy();
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

    public Code.DataServiceComponent dataService { get { return (Code.DataServiceComponent)GetComponent(ServicesComponentsLookup.DataService); } }
    public bool hasDataService { get { return HasComponent(ServicesComponentsLookup.DataService); } }

    public void AddDataService(Code.IDataService newValue) {
        var index = ServicesComponentsLookup.DataService;
        var component = (Code.DataServiceComponent)CreateComponent(index, typeof(Code.DataServiceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDataService(Code.IDataService newValue) {
        var index = ServicesComponentsLookup.DataService;
        var component = (Code.DataServiceComponent)CreateComponent(index, typeof(Code.DataServiceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDataService() {
        RemoveComponent(ServicesComponentsLookup.DataService);
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

    static Entitas.IMatcher<ServicesEntity> _matcherDataService;

    public static Entitas.IMatcher<ServicesEntity> DataService {
        get {
            if (_matcherDataService == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.DataService);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherDataService = matcher;
            }

            return _matcherDataService;
        }
    }
}
