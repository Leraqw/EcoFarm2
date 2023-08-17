﻿using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Player] public sealed class ForPlayerButtonComponent : IComponent { }
	[Player] public sealed class PlayerChoiceButtonComponent : IComponent { }
	[Game] public sealed class PlayerChoiceWindowComponent : IComponent { }
	[Game] public sealed class ToggledComponent : IComponent { }
	[Player] [Event(Self)] public sealed class InteractableComponent : IComponent { public bool Value; }
}