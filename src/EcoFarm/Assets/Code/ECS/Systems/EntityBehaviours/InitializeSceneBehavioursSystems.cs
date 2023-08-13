using System.Collections.Generic;
using Entitas;
using UnityEngine;

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
				behaviour.Initialize(_contexts);
			}
		}
	}

	public interface IEntityBehavioursProvider
	{
		IEnumerable<RegistrableEntityBehaviour> Behaviours { get; }
	}

	public class FindBehavioursProvider : IEntityBehavioursProvider
	{
		public IEnumerable<RegistrableEntityBehaviour> Behaviours
			=> Object.FindObjectsOfType<RegistrableEntityBehaviour>();
	}
}