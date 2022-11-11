using Code.Data.StorageJson;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityDataService : IDataService
	{
		private readonly IDataAccess _data;

		public UnityDataService() => _data = new StorageAccess();

		public int TreesCount => _data.TreesCount;
	}
}