using Code.Data.DataBase;
using Code.Services.Interfaces;

namespace Code.Services.UnityImplementations
{
	public class UnityDataBaseService : IDataBaseService
	{
		private readonly IDataAccess _data;

		public UnityDataBaseService() => _data = new DataBaseAccess();

		public int TreesCount => _data.TreesCount;
	}
}