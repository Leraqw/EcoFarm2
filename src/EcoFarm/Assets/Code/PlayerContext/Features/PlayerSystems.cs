using Code.PlayerContext.Systems;

namespace Code.PlayerContext.Features
{
	internal sealed class PlayerSystems : Feature
	{
		public PlayerSystems()
		{
			var contexts =  Contexts.sharedInstance;
			Add(new InitializePlayerContextSystem(contexts));
		}
		
		public void OnUpdate()
		{
			
		}
	}
}