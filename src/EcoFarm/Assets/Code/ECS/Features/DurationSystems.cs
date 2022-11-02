using Code.ECS.Systems.Common;

namespace Code.ECS.Features
{
	public sealed class DurationSystems : Feature
	{
		public DurationSystems(Contexts contexts)
			: base(nameof(DurationSystems))
		{
			Add(new DurationSystem(contexts));
			Add(new CheckDurationUpSystem(contexts));
		}
	}
}