
using UnityEngine;

namespace EcoFarm
{
	public abstract class BaseViewListener : MonoBehaviour
	{
		public GameEntity Entity { get; private set; }

		public void Register(GameEntity entity)
			=> entity
			   .Do((e) => Entity = e)
			   .Do(AddListener)
			   .Do(UpdateValue, @if: HasComponent);

		protected abstract void AddListener(GameEntity entity);

		protected abstract bool HasComponent(GameEntity entity);

		protected abstract void UpdateValue(GameEntity entity);
	}
}