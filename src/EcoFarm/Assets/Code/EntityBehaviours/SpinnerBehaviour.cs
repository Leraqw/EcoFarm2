using Zenject;

namespace EcoFarm
{
	public class SpinnerBehaviour : StartEntityBehaviour
	{
		private GameEntity.Factory _gameEntityFactory;

		[Inject]
		public void Construct(GameEntity.Factory gameEntityFactory)
			=> _gameEntityFactory = gameEntityFactory;

		protected override void Initialize()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("Windmill Rotation");
			e.isSpinner = true;
			e.AddRotationSpeed(1f);
			e.AddRotation(0);
			e.AddView(gameObject);
		}
	}
}