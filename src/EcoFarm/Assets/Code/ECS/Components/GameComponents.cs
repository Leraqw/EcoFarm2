using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace EcoFarm
{
	[Game] public sealed class RequireViewComponent : IComponent { public string Value; }
	[Game] public sealed class ViewPrefabComponent : IComponent { public GameObject Value; }
	[Game, Player] public sealed class ViewComponent : IComponent { public GameObject Value; }
	[Game] public sealed class SpawnPositionComponent : IComponent { public Vector2 Value; }
	[Game] [Event(Self)] public sealed class PositionComponent : IComponent { public Vector2 Value; }
	[Game] [Event(Self)] public sealed class DurationComponent : IComponent { public float Value; }
	[Game] [Cleanup(RemoveComponent)] public sealed class DurationUpComponent : IComponent { }
	[Game] public sealed class DebugNameComponent : IComponent { public string Value; }
	[Game] [Event(Self)] public sealed class ProportionalScaleComponent : IComponent { public float Value; }
	[Game] public sealed class TargetScaleComponent : IComponent { public float Value; }
	[Game] public sealed class TargetPositionComponent : IComponent { public Vector2 Value; }
	[Game] public sealed class AttachableIndexComponent : IComponent { [PrimaryEntityIndex] public int Value; }
	[Game] public sealed class AttachedToComponent : IComponent { [EntityIndex] public int Value; }
	[Game] public sealed class DroughtTimerComponent : IComponent { }
	[Game] public sealed class RequireSpriteComponent : IComponent { public string Value; }
	[Game] public sealed class SpriteToLoadComponent : IComponent { public Sprite Value; }
	[Game] [Event(Self)] public sealed class SpriteComponent : IComponent { public Sprite Value; }
}