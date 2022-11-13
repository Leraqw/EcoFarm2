using Code.PlayerContext.Systems;

namespace Code.PlayerContext.Features
{
	internal sealed class PlayerSystems : Feature
	{
		public PlayerSystems()
		{
			Add(new InitializePlayerContextSystem());
		}
		
		public void OnUpdate()
		{
			
		}
	}
}