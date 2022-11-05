using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Services] [Unique] public sealed class ResourcesServiceComponent : ValueComponent<IResourcesService> { }

	[Services] [Unique] public sealed class SceneObjectsServiceComponent : ValueComponent<ISpawnPointsService> { }

	[Services] [Unique] public sealed class StorageServiceComponent : ValueComponent<IStorageService> { }
	
	[Services] [Unique] public sealed class DataBaseServiceComponent : ValueComponent<IDataBaseService> { }
	
	[Services] [Unique] public sealed class CameraServiceComponent : ValueComponent<ICameraService> { }
	
	[Services] [Unique] public sealed class InputServiceComponent : ValueComponent<IInputService> { }
	
	[Services] [Unique] public sealed class ConfigurationServiceComponent : ValueComponent<IConfigurationService> { }
}