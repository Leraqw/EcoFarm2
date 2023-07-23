using EcoFarmModel;

namespace Code
{
	public interface IDataService : IService
	{
		Storage Storage { get; }
	}
}