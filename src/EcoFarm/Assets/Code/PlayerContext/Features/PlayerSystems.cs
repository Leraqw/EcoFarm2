using Code.PlayerContext.Systems;
using Code.Utils.Extensions.Entitas;

namespace Code.PlayerContext.Features
{
	public sealed class PlayerSystems : Feature
	{
		public PlayerSystems()
		{
			var contexts = Contexts.sharedInstance;

			Add(new InitializePlayerContextSystem(contexts));
		}

		public void OnUpdate() => this.ExecuteAnd().Cleanup();
	}
}