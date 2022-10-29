using Code.Utils.ComponentsTemplates;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.ECS.Components
{
	[Cleanup(DestroyEntity)] [Game] public sealed class OnMouseClickComponent : ValueComponent<Entity> { }
}