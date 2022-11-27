using EcoFarmModel;

namespace Code.Data.StorageJson
{
	public interface IDataAccess
	{
		int  TreesCount { get; }
		Tree AppleTree  { get; }
	}
}