using EcoFarmModel;

namespace EcoFarm
{
	public interface IDataService : IService
	{
		StorageSO Storage { get; }
	}
}