using Code.Data.ToUnity;

namespace Code.Services.Game.Interfaces.Config.ResourcesConfigs
{
	public interface IResourceConfig
	{
		IPrefabConfig Prefab { get; }
		ISpriteConfig Sprite { get; }
		SpriteSheet SpriteSheet { get; }
	}
}