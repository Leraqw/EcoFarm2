

namespace Code
{
	public sealed class CleanupSystems : Feature
	{
		public CleanupSystems(Contexts contexts)
			: base(nameof(CleanupSystems))
		{
			Add(new RemoveTargetsOnTimeUpSystem(contexts));
		}
	}
}