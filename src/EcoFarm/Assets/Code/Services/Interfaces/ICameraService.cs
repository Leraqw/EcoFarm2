using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface ICameraService
	{
		Vector2 ScreenToWorldPoint(Vector2 screenPosition);
	}
}