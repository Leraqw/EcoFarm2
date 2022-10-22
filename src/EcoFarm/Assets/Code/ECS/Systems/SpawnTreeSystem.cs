using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreeSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => Debug.Log("Заспавнилось дерево");
	}
}