namespace Code.Data
{
	public class Configuration
	{
		public Configuration(int treesCount) => TreesCount = treesCount;

		public int TreesCount { get; }
	}
}