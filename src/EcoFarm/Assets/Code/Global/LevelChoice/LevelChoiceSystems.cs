using Code.Global.LevelChoice.Systems;

namespace Code.Global.LevelChoice
{
	public sealed class LevelChoiceSystems : Feature
	{
		public LevelChoiceSystems()
		{
			var contexts = Contexts.sharedInstance;

			// Add(new LevelsInitializationSystem(contexts));

			Add(new TearDownLevelsSystems(contexts));
		}
	}
}