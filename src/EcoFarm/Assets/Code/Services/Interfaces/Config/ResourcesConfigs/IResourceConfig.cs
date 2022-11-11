namespace Code.Services.Interfaces.Config.ResourcesConfigs
{
	public interface IResourceConfig
	{
		IPrefabConfig Prefab { get; }
		ISpriteConfig Sprite { get; }
	}
}