using EcoFarm;

namespace Services
{
	public class SingletonServices
	{
		private IDataProviderService _dataProvider;
		private static SingletonServices _instance;

		public static SingletonServices Instance => _instance ??= new SingletonServices();

		public IDataProviderService DataProvider => _dataProvider ??= new SerializableObjectDataProvider();

		private SingletonServices() { }
	}
}