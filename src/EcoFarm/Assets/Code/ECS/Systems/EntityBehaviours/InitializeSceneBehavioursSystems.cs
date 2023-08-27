using Entitas;

namespace EcoFarm
{
	public sealed class InitializeSceneBehavioursSystems : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly RegistrableEntityBehaviour[] _entityBehaviours;

		public InitializeSceneBehavioursSystems(Contexts contexts, RegistrableEntityBehaviour[] entityBehaviours)
		{
			_contexts = contexts;
			_entityBehaviours = entityBehaviours;
		}

		public void Initialize()
		{
			foreach (var behaviour in _entityBehaviours)
			{
				behaviour.Initialize();
			}
		}
	}
}