using Code.Utils.Extensions;
using UnityEngine;

namespace Code.Unity.ViewListeners
{
	public abstract class BaseViewListener : MonoBehaviour
	{
		public void Register(GameEntity entity) => entity.Do(AddListener).Do(UpdateValue, @if: HasComponent);

		protected abstract void AddListener(GameEntity entity);

		protected abstract bool HasComponent(GameEntity entity);

		protected abstract void UpdateValue(GameEntity entity);
	}
}