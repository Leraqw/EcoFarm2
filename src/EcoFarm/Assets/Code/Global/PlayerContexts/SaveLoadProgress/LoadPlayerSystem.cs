﻿using Entitas;

namespace EcoFarm
{
	public sealed class LoadPlayerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public LoadPlayerSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			var e = _contexts.player.CreateEntity();
			e.isPlayer = true;
			e.AddSessionResult(SessionResult.None);
		}
	}
}