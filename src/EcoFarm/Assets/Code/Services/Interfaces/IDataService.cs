using EcoFarmModel;

namespace Code.Services.Interfaces
{
	public interface IDataService : IService
	{
		Storage Storage { get; }
	}
}