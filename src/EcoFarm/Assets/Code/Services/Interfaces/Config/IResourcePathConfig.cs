using Code.Services.Interfaces.Config.ResourcesConfigs;

namespace Code.Services.Interfaces.Config
{
	public interface IResourcePathConfig
	{
		IPrefabConfig Prefab { get; }
	}
}