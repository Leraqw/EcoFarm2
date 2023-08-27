using EcoFarm;
using Zenject;

public partial class GameEntity
{
	public class Factory : PlaceholderFactory<GameEntity>
	{
		private readonly Injector _injector;

		[Inject] public Factory(Injector injector) => _injector = injector;

		public override GameEntity Create()
		{
			var gameEntity = Contexts.sharedInstance.game.CreateEntity();
			_injector.Inject(gameEntity);
			return gameEntity;
		}
	}
}