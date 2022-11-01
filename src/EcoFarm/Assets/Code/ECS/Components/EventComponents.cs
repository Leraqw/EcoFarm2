using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.ECS.Components
{
	[Game] [Cleanup(DestroyEntity)] public sealed class MouseClickComponent : ValueComponent<GameEntity> { }
}