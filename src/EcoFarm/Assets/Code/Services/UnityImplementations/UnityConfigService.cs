using Code.Data;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityConfigService : IConfigService
	{
		private readonly Config _config;

		public UnityConfigService(IStorage storageService) => _config = storageService.Load(Config.Default);

		public int TreesCount => _config.TreesCount;
	}
}