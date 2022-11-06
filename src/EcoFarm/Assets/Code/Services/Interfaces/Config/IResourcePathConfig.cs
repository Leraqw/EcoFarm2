using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Unity.SO.Configuration;

namespace Code.Services.Interfaces.Config
{
	public interface IResourcePathConfig
	{
		IPrefabConfig Prefab { get; }
		ISpriteConfig Sprite { get; }
	}
}