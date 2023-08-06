using EcoFarmModel;

namespace EcoFarm
{
	public interface IDataAccess
	{
		int  TreesCount { get; }
		Tree AppleTree  { get; }
	}
}