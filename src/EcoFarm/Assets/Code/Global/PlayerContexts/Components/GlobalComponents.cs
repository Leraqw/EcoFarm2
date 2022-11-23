using Code.Global.PlayerContexts.CustomTypes;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using Packages.Code.Ecs.Components.Workflow;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.Global.PlayerContexts.Components
{
	[Player] public sealed class NicknameComponent : PrimaryComponent<string> { }

	[Player] [Unique] public sealed class CurrentPlayerComponent : FlagComponent { }
	
	[Player] public sealed class PlayerComponent : FlagComponent { }

	[Player] public sealed class SessionResultComponent : ValueComponent<SessionResult> { }

	[Game, Player] [Cleanup(DestroyEntity)] public sealed class DestroyComponent : FlagComponent { }

	[Player] public sealed class SelectedLevelComponent : ValueComponent<int> { }

	[Player] public sealed class CompletedLevelsCountComponent : ValueComponent<int> { }
}