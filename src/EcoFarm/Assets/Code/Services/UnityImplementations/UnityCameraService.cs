using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityCameraService : ICameraService
	{
		private readonly Camera _camera;

		public UnityCameraService() => _camera = Camera.main;

		public Vector2 ScreenToWorldPoint(Vector2 screenPosition) 
			=> _camera.ScreenToWorldPoint(screenPosition);
	}
}