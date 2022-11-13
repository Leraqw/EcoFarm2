using Code.ECS.Features.Features;
using Code.PlayerContext.Systems;
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;

namespace Code.PlayerContext.Features
{
	public sealed class PlayerSystems : Feature
	{
		public PlayerSystems(IGlobalServices services)
		{
			var contexts = Contexts.sharedInstance;

			Add(new GlobalServicesRegistrationSystems(contexts, services));

			Add(new InitializePlayerContextSystem(contexts));
			
			Add(new OnSessionEndSystem(contexts));
		}

		public void OnUpdate() => this.ExecuteAnd().Cleanup();
	}
}