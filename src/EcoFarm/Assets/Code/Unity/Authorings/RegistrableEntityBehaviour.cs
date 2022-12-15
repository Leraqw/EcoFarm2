using UnityEngine;

namespace Code
{
	public class RegistrableEntityBehaviour : MonoBehaviour
	{
		[SerializeField] private RegistrarBase[] _registrars;

		private void Awake()
		{
			var entity = Contexts.sharedInstance.game.CreateEntity();

			foreach (var registrar in _registrars)
			{
				registrar.Register(ref entity);
			}
		}
	}
}