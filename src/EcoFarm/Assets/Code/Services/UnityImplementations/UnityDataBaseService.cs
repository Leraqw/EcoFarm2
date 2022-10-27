using Code.Data.DataBase;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityDataBaseService : IDataBaseService
	{
		private readonly DataBaseAccess _dataBase;

		public UnityDataBaseService() => _dataBase = new DataBaseAccess();

		public int TreesCount => _dataBase.TreesCount;
	}
}