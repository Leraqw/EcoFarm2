using UnityEngine;

namespace EcoFarm
{
	public abstract class RegistrarBase : MonoBehaviour
	{
		public abstract void Register(ref GameEntity entity);
	}
}