﻿

using Entitas;

namespace Code
{
	public sealed class SpawnDroughtTimerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnDroughtTimerSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("DroughtTimer"))
			            .Do((e) => e.isDroughtTimer = true)
			            .ResetDroughtTimer();
	}
}