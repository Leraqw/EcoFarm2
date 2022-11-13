using Code.PlayerContext.Systems;
using Code.Utils.Extensions;

namespace Code.PlayerContext.Features
{
	public sealed class PlayerSystems : Feature
	{
		public PlayerSystems()
		{
			var contexts =  Contexts.sharedInstance;
			Add(new InitializePlayerContextSystem(contexts));
		}
		
		public void OnUpdate() => this.Do((t) => t.Execute()).Do((t) => t.Cleanup());
	}
}