using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityInputService : IInputService
	{
		public Vector2 MousePosition => Input.mousePosition;
	}
}