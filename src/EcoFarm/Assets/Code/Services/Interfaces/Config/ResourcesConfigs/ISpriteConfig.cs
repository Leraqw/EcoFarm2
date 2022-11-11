namespace Code.Services.Interfaces.Config.ResourcesConfigs
{
	public interface ISpriteConfig
	{
		IBucketSpritesConfig Bucket { get; }
		ITreeSpritesConfig Tree { get; }
	}
}