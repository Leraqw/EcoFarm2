using Code.ECS.Systems.Tree;

namespace Code.ECS.Features.Initialization
{
	public sealed class DataBaseLoadSystems : Feature
	{
		public DataBaseLoadSystems(Contexts contexts)
			: base(nameof(DataBaseLoadSystems))
		{
			Add(new EmitPositionsForTreeSpawnSystem(contexts));
		}
	}
}