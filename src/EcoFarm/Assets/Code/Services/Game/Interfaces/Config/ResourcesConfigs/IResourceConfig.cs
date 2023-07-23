namespace Code
{
	public interface IResourceConfig
	{
		IPrefabConfig Prefab      { get; }
		ISpriteConfig Sprite      { get; }
		SpriteSheet   SpriteSheet { get; }
	}
}