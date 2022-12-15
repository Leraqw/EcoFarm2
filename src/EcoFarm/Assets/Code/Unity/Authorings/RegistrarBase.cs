using UnityEngine;

namespace Code
{
	public abstract class RegistrarBase : MonoBehaviour
	{
		public abstract void Register(ref GameEntity entity);
	}
}