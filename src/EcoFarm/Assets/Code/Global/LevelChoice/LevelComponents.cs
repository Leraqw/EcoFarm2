using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Player] public sealed class LevelRelatedEntityComponent : IComponent { }
	[Player] [Event(Self)] public sealed class UnlockedLevelsCountComponent : IComponent { public int Value; }
}