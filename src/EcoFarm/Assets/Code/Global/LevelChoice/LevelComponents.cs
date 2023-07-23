
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code
{
	[Player] public sealed class LevelRelatedEntityComponent : FlagComponent { }

	[Player] [Event(Self)] public sealed class UnlockedLevelsCountComponent : ValueComponent<int> { }
}