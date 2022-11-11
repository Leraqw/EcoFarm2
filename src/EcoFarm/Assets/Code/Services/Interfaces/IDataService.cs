using EcoFarmDataModule;

namespace Code.Services.Interfaces
{
	public interface IDataService : IService
	{
		int  TreesCount { get; }
		Tree AppleTree  { get; }
	}
}