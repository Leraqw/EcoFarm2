using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Event(Self)] [Cleanup(RemoveComponent)] public sealed class ClearChildrensComponent : FlagComponent { }
}