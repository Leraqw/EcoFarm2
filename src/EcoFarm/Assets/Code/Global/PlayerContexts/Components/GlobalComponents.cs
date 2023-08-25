using Entitas;
using Entitas.CodeGeneration.Attributes;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace EcoFarm
{
	[Player] public sealed class NicknameComponent : IComponent { public string Value;}

	[Player] [Unique] public sealed class CurrentPlayerComponent : IComponent { }

	[Player] public sealed class PlayerComponent : IComponent { }

[Player] public sealed class SessionResultComponent : IComponent { public SessionResult Value; }

[Game, Player] [Cleanup(DestroyEntity)] public sealed class DestroyComponent : IComponent { }

[Player] public sealed class SelectedLevelComponent : IComponent { public int Value; }

[Player] public sealed class CompletedLevelsCountComponent : IComponent { public int Value; }
}