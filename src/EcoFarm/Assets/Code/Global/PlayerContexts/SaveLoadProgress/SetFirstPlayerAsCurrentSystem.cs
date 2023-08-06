using System.Linq;
using Entitas;

namespace EcoFarm
{
	public sealed class SetFirstPlayerAsCurrentSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SetFirstPlayerAsCurrentSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.player.GetGroup(PlayerMatcher.Player)
			            .GetEntities()
			            .First()
			            .isCurrentPlayer = true;
	}
}