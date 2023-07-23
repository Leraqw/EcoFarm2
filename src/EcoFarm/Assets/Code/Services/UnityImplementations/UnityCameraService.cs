
using UnityEngine;

namespace Code
{
	public class UnityCameraService : ICameraService
	{
		private static Camera Camera => Camera.main;

		public Vector2 ScreenToWorldPoint(Vector2 screenPosition)
			=> Camera.ScreenToWorldPoint(screenPosition);
	}
}