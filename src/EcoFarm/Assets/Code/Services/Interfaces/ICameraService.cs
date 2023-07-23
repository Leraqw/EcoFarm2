using UnityEngine;

namespace Code
{
	public interface ICameraService
	{
		Vector2 ScreenToWorldPoint(Vector2 screenPosition);
	}
}