//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity dataProviderEntity { get { return GetGroup(ServicesMatcher.DataProvider).GetSingleEntity(); } }
    public Code.DataProviderComponent dataProvider { get { return dataProviderEntity.dataProvider; } }
    public bool hasDataProvider { get { return dataProviderEntity != null; } }

    public ServicesEntity SetDataProvider(Code.IDataProviderService newValue) {
        if (hasDataProvider) {
            throw new Entitas.EntitasException("Could not set DataProvider!\n" + this + " already has an entity with Code.DataProviderComponent!",
                "You should check if the context already has a dataProviderEntity before setting it or use context.ReplaceDataProvider().");
        }
        var entity = CreateEntity();
        entity.AddDataProvider(newValue);
        return entity;
    }

    public void ReplaceDataProvider(Code.IDataProviderService newValue) {
        var entity = dataProviderEntity;
        if (entity == null) {
            entity = SetDataProvider(newValue);
        } else {
            entity.ReplaceDataProvider(newValue);
        }
    }

    public void RemoveDataProvider() {
        dataProviderEntity.Destroy();
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

    public Code.DataProviderComponent dataProvider { get { return (Code.DataProviderComponent)GetComponent(ServicesComponentsLookup.DataProvider); } }
    public bool hasDataProvider { get { return HasComponent(ServicesComponentsLookup.DataProvider); } }

    public void AddDataProvider(Code.IDataProviderService newValue) {
        var index = ServicesComponentsLookup.DataProvider;
        var component = (Code.DataProviderComponent)CreateComponent(index, typeof(Code.DataProviderComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDataProvider(Code.IDataProviderService newValue) {
        var index = ServicesComponentsLookup.DataProvider;
        var component = (Code.DataProviderComponent)CreateComponent(index, typeof(Code.DataProviderComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDataProvider() {
        RemoveComponent(ServicesComponentsLookup.DataProvider);
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

    static Entitas.IMatcher<ServicesEntity> _matcherDataProvider;

    public static Entitas.IMatcher<ServicesEntity> DataProvider {
        get {
            if (_matcherDataProvider == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.DataProvider);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherDataProvider = matcher;
            }

            return _matcherDataProvider;
        }
    }
}
