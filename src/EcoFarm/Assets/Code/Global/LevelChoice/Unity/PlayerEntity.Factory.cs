using EcoFarm;
using Zenject;

public partial class PlayerEntity
{
	public class Factory : PlaceholderFactory<PlayerEntity>
	{
		private readonly Injector _injector;

		[Inject] public Factory(Injector injector) => _injector = injector;

		public override PlayerEntity Create()
		{
			var playerEntity = Contexts.sharedInstance.player.CreateEntity();
			_injector.Inject(playerEntity);
			return playerEntity;
		}
	}
}