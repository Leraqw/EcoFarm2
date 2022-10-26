using Code.Data.Config;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityDataBaseService : IDataBaseService
	{
		private readonly Config _config;

		public UnityDataBaseService(IStorage storageService) => _config = storageService.Load(Config.Default);

		public int TreesCount => _config.TreesCount;
	}
}