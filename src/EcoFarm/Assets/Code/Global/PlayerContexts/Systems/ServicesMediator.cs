using UnityEngine;

namespace Code
{
	public static class ServicesMediator
	{
		private static ServicesContext Context => Contexts.sharedInstance.services;

		public static IDataProviderService DataProvider  => Context.dataProvider.Value;
		public static ICameraService       CameraService => Context.cameraService.Value;
		public static IInputService        InputService  => Context.inputService.Value;

		public static Vector2 MouseWorldPosition => CameraService.ScreenToWorldPoint(InputService.MousePosition);
	}
}