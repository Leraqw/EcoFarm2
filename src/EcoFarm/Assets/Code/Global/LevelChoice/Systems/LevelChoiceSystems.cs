namespace Code.Global.LevelChoice.Systems
{
	public sealed class LevelChoiceSystems : Feature
	{
		public LevelChoiceSystems()
		{
			var contexts = Contexts.sharedInstance;

			Add(new TearDownLevelsSystems(contexts));
		}
	}
}