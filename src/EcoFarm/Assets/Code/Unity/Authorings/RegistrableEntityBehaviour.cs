using UnityEngine;

namespace Code
{
	public class RegistrableEntityBehaviour : MonoBehaviour
	{
		[SerializeField] private RegistrarBase[] _registrars;

		private void OnEnable()
		{
			_registrars = GetComponents<RegistrarBase>();
		}

		public void Initialize(Contexts contexts)
		{
			var entity = contexts.game.CreateEntity();

			foreach (var registrar in _registrars)
			{
				registrar.Register(ref entity);
			}
		}
	}
}