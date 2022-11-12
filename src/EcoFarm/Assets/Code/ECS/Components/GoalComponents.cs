using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] public sealed class GoalCompletedComponent : FlagComponent { }

	[Game] [Event(Self)] public sealed class CurrentQuantityComponent : ValueComponent<int> { }
}