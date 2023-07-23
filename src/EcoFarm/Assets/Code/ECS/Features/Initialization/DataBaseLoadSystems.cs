﻿namespace Code
{
	public sealed class DataBaseLoadSystems : Feature
	{
		public DataBaseLoadSystems(Contexts contexts)
			: base(nameof(DataBaseLoadSystems))
		{
			Add(new EmitPositionsForTreeSpawnSystem(contexts));
		}
	}
}