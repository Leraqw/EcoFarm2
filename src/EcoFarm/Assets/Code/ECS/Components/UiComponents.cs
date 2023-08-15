using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] [Event(Self)] public sealed class ActivateComponent : IComponent { public bool Value; }
	[Game] [Cleanup(RemoveComponent)] public sealed class ButtonClickComponent : IComponent { }
	[Game] public sealed class SellWindowComponent : IComponent { public WindowSell Value; }
	[Game] public sealed class BuildWindowComponent : IComponent { public WindowScroll Value; }
	[Game] public sealed class PlayerChoiceWindowComponent : IComponent { public WindowScroll Value; }
	[Game] public sealed class TargetActivityComponent : IComponent { public bool Value; }
	[Game] [Event(Self)] public sealed class SliderMaxValueComponent : IComponent { public float Value; }
	[Game] [Event(Self)] public sealed class SliderValueComponent : IComponent { public float Value; }
	[Game] public sealed class RequirePreparationComponent : IComponent { }
	[Game] public sealed class PreparationInProcessComponent : IComponent { }
	[Game] public sealed class PreparedComponent : IComponent { }
	[Game, Player] [Event(Self)] public sealed class TextComponent : IComponent { public string Value; }
	[Game] public sealed class UiElementComponent : IComponent { }
	[Game] public sealed class UiParentComponent : IComponent { public RectTransform Value; }
	[Game] [Event(Self)] public sealed class ProgressBarComponent : IComponent { public ProgressBarValues Value; }
}