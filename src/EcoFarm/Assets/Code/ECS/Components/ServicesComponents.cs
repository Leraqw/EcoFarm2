using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace EcoFarm
{
	[Services] [Unique] public sealed class ResourcesServiceComponent : IComponent { public IResourcesService Value; }
	[Services] [Unique] public sealed class SceneObjectsServiceComponent : IComponent { public ISpawnPointsService Value; }
	[Services] [Unique] public sealed class StorageServiceComponent : IComponent { public IStorageService Value; }
	[Services] [Unique] public sealed class CameraServiceComponent : IComponent { public ICameraService Value; }
	[Services] [Unique] public sealed class InputServiceComponent : IComponent { public IInputService Value; }
	[Services] [Unique] public sealed class ConfigurationServiceComponent : IComponent { public IConfigurationService Value; }
	[Services] [Unique] public sealed class UiServiceComponent : IComponent { public IUiService Value; }
	[Services] [Unique] public sealed class SceneTransferServiceComponent : IComponent { public ISceneTransferService Value; }
}