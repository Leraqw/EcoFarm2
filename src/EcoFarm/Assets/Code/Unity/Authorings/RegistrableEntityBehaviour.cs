using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class RegistrableEntityBehaviour : MonoBehaviour
	{
		[SerializeField] private AuthoringBase[] _registrars;

		private GameEntity.Factory _gameEntityFactory;

		[Inject]
		public void Construct(GameEntity.Factory gameEntityFactory)
			=> _gameEntityFactory = gameEntityFactory;

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

		public void Initialize()
		{
			var entity = _gameEntityFactory.Create();

			foreach (var registrar in _registrars)
			{
				registrar.Register(ref entity);
			}
		}
	}
}