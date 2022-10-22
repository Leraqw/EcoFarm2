using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class GreeterSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public GreeterSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => Debug.Log($"{_contexts} Hello, World!");
	}
}