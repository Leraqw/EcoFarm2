
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] [Event(Self)] public sealed class GoalCompletedComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class CurrentQuantityComponent : ValueComponent<int> { }

	[Game] [Unique] public sealed class LevelTimerComponent : FlagComponent { }
}