using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ServicesMediator
	{
		private readonly ICameraService _cameraService;
		private readonly IInputService _inputService;

		[Inject]
		public ServicesMediator(ICameraService cameraService, IInputService inputService)
		{
			_inputService = inputService;
			_cameraService = cameraService;
		}

		public Vector2 MouseWorldPosition => _cameraService.ScreenToWorldPoint(_inputService.MousePosition);
	}
}