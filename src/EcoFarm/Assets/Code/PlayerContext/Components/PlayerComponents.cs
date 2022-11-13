using Code.PlayerContext.CustomTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.PlayerContext.Components
{
	[Player] public sealed class NameComponent : ValueComponent<string> { }

	[Player] [Unique] public sealed class PlayerComponent : FlagComponent { }

	[Player] public sealed class SessionResultComponent : ValueComponent<SessionResult> { }
}