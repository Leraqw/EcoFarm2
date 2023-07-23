using EcoFarmModel;

namespace Code
{
	public interface IDataAccess
	{
		int  TreesCount { get; }
		Tree AppleTree  { get; }
	}
}