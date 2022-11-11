using Code.Data.StorageJson;
using Code.Services.Interfaces;
using EcoFarmDataModule;

namespace Code.Services.UnityImplementations
{
	public class UnityDataService : IDataService
	{
		private readonly IDataAccess _data;

		public UnityDataService() => _data = new StorageAccess();

		public int  TreesCount => _data.TreesCount;

		public Tree AppleTree => _data.AppleTree;
	}
}