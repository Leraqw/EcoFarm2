
using UnityEngine;

namespace Code
{
	public class UnityInputService : IInputService
	{
		public Vector2 MousePosition => Input.mousePosition;
	}
}