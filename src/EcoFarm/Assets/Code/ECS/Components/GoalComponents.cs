using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Game] [Event(Self)] public sealed class GoalCompletedComponent : IComponent { }
	[Game] [Event(Self)] public sealed class CurrentQuantityComponent : IComponent { public int Value; }
	[Game] [Unique] public sealed class LevelTimerComponent : IComponent { }
}