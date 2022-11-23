namespace Code.Global.LevelChoice.Unity
{
	public static class LevelChoiceExtensions
	{
		public static int GetCompletedUnlockedLevelsCount(this PlayerEntity @this)
			=> @this.hasCompletedLevelsCount ? @this.completedLevelsCount : @this.unlockedLevelsCount;
	}
}