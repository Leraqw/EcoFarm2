using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Game] [Unique] public sealed class WaterResourceComponent : FlagComponent { }

	[Game] [Unique] public sealed class EnergyResourceComponent : FlagComponent { }
}