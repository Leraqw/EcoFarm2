﻿using Code.ECS.Systems.Watering.Bucket;
using Code.ECS.Systems.Watering.Crane;
using Code.ECS.Systems.Watering.Drought;
using Code.ECS.Systems.Watering.Tree;

namespace Code.ECS.Features
{
	public sealed class WateringSystems : Feature
	{
		public WateringSystems(Contexts contexts)
			: base(nameof(WateringSystems))
		{
			Add(new PourWaterSystem(contexts));
			Add(new WaterNearTreeSystem(contexts));
			Add(new OnTreeWateredSystem(contexts));
			Add(new ClickOnCraneSystem(contexts));

			Add(new SpawnDroughtTimerSystem(contexts));
			Add(new DroughtTreeSystem(contexts));
			Add(new ResetDroughtTimerSystem(contexts));
			Add(new SyncSpriteWithBucketStateSystem(contexts));
		}
	}
}