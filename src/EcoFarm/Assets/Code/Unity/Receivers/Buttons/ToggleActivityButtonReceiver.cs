using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ToggleActivityButtonReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private BaseViewListener _window;
		[SerializeField] private bool _targetActivity;

		private GameEntity.Factory _gameEntityFactory;

		[Inject]
		public void Construct(GameEntity.Factory gameEntityFactory)
			=> _gameEntityFactory = gameEntityFactory;

		protected override void OnButtonClick()
		{
			var e = _gameEntityFactory.Create();
			e.AddAttachedTo(_window.Entity.attachableIndex.Value);
			e.AddTargetActivity(_targetActivity);
		}
	}
}