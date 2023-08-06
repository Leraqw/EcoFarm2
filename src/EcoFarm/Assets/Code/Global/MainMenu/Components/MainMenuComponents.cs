using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Player] public sealed class ForPlayerButtonComponent : IComponent { }
	[Player] [Event(Self)] public sealed class InteractableComponent : IComponent { public bool Value; }
}