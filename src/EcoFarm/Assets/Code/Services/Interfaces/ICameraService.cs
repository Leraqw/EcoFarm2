using UnityEngine;

namespace EcoFarm
{
	public interface ICameraService
	{
		Vector2 ScreenToWorldPoint(Vector2 screenPosition);
	}
}