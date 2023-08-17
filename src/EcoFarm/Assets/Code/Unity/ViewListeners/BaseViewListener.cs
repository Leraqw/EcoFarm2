using System;
using UnityEngine;

namespace EcoFarm
{
	public abstract class BaseViewListener : MonoBehaviour
	{
		public GameEntity Entity { get; private set; }

		public void Register(GameEntity entity)
		{
			Entity = entity;
			AddListener(entity);
			
			if (HasComponent(Entity))
				UpdateValue(Entity);
		}

		protected abstract void AddListener(GameEntity entity);

		protected abstract bool HasComponent(GameEntity entity);

		protected abstract void UpdateValue(GameEntity entity);
	}
}