using Entitas;

namespace EcoFarm
{
	public abstract class FeatureBase : Feature
	{
		private readonly SystemsFactory _factory;

		protected FeatureBase(string name, SystemsFactory factory)
			: base(name)
			=> _factory = factory;

		protected void Add<TSystem>() where TSystem : ISystem => Add(_factory.Create<TSystem>());
	}
}