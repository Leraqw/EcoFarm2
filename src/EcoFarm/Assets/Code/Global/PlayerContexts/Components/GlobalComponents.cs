using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code
{
	[Player] public sealed class NicknameComponent : IComponent { [PrimaryEntityIndex] public string Value;}

	[Player] [Unique] public sealed class CurrentPlayerComponent : IComponent { }

	[Player] public sealed class PlayerComponent : IComponent { }

	[Player] public sealed class SessionResultComponent : ValueComponent<SessionResult> { }

	[Game, Player] [Cleanup(DestroyEntity)] public sealed class DestroyComponent : FlagComponent { }

	[Player] public sealed class SelectedLevelComponent : ValueComponent<int> { }

	[Player] public sealed class CompletedLevelsCountComponent : ValueComponent<int> { }
}