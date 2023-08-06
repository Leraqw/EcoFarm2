
using UnityEngine;

namespace EcoFarm
{
	public class UnityInputService : IInputService
	{
		public Vector2 MousePosition => Input.mousePosition;
	}
}