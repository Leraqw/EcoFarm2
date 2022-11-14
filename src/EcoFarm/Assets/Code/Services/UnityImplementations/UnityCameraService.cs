using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityCameraService : ICameraService
	{
		private static Camera Camera => Camera.main;

		public Vector2 ScreenToWorldPoint(Vector2 screenPosition)
			=> Camera.ScreenToWorldPoint(screenPosition);
	}
}