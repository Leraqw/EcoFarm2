using EcoFarmModel;

namespace EcoFarm
{
	public interface IDataService : IService
	{
		Storage Storage { get; }
	}
}