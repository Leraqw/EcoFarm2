using UnityEngine;

namespace EcoFarm
{
	public class RegistrableEntityBehaviour : MonoBehaviour
	{
		[SerializeField] private AuthoringBase[] _registrars;

		private void OnEnable()
		{
#if UNITY_EDITOR
			var actualCount = GetComponents<AuthoringBase>().Length;
			var addedCount = _registrars.Length;
			if (actualCount != addedCount)
			{
				_registrars = GetComponents<AuthoringBase>();
				Debug.LogError($"Mismatch in authorings count! should be {actualCount}, but is {addedCount}");
			}
#endif
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