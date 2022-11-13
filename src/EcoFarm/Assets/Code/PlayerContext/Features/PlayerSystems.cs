using Code.PlayerContext.Systems;

namespace Code.PlayerContext.Unity
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