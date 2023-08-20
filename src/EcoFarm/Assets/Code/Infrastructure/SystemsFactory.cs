using Entitas;
using Zenject;

namespace EcoFarm
{
	public class SystemsFactory
	{
		private readonly DiContainer _container;

		[Inject] public SystemsFactory(DiContainer container) => _container = container;

		public TSystem Create<TSystem>() where TSystem : ISystem => _container.Instantiate<TSystem>();
	}
}