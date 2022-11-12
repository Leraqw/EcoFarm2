using Code.Utils.ComponentsTemplates;

namespace Code.ECS.Components
{
	[Game] public sealed class GoalCompletedComponent : FlagComponent { }

	[Game] public sealed class CurrentQuantityComponent : ValueComponent<int> { }
}