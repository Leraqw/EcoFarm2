using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityCameraService : ICameraService
	{
		public Vector2 ScreenToWorldPoint(Vector2 screenPosition) 
			=> Camera.main!.ScreenToWorldPoint(screenPosition);
	}
}