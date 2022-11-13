namespace Code.Services.Game.Interfaces.Config.ResourcesConfigs
{
	public interface ISpriteConfig
	{
		IBucketSpritesConfig Bucket { get; }
		ITreeSpritesConfig Tree { get; }
	}
}