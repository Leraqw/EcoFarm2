using Code.Global.PlayerContext.CustomTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.Global.PlayerContext.Components
{
	[Player] public sealed class NameComponent : ValueComponent<string> { }

	[Player] [Unique] public sealed class PlayerComponent : FlagComponent { }

	[Player] public sealed class SessionResultComponent : ValueComponent<SessionResult> { }

	[Game, Player] [Cleanup(DestroyEntity)] public sealed class DestroyComponent : FlagComponent { }
}