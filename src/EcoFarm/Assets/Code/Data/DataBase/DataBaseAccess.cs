using System.IO;
using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public class DataBaseAccess
	{
		private const string DataBaseName = "URI=file:EcoFarm.db";

		public void CreateDataBase()
		{
			if (File.Exists("EcoFarm.db") == false)
			{
				SqliteConnection.CreateFile(DataBaseName);
			}
		}
	}
}