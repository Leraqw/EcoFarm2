namespace EcoFarm
{
	public interface IResourceConfig
	{
		IPrefabConfig Prefab      { get; }
		ISpriteConfig Sprite      { get; }
	}
}