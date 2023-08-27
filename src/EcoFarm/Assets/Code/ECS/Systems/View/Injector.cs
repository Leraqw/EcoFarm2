using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class Injector // TODO: Temporary class to keep all .Inject usages in one place
	{
		private readonly DiContainer _container;

		[Inject] public Injector(DiContainer container) => _container = container;

		public void InjectGameObject(GameObject gameObject) => _container.InjectGameObject(gameObject);

		public void Inject<T>(T injectable) => _container.Inject(injectable);
	}
}