using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.Global.MainMenu.Components
{
	[Player] public sealed class ForPlayerButtonComponent : FlagComponent { }

	[Player] [Event(Self)] public sealed class InteractableComponent : ValueComponent<bool> { }
}