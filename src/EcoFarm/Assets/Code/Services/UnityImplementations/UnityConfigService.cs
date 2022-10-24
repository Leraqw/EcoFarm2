using Code.Data;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityConfigService : Config, IConfigService
	{
		public new int TreesCount => base.TreesCount;
		public new IConfigService Default => new UnityConfigService(TreesCount);

		public UnityConfigService(int treesCount)
			: base(treesCount) { }
	}
}