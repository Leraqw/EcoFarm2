﻿namespace EcoFarm
{
	public static class BuildingsExtensions
	{
		public static bool HasSamePosition(this GameEntity @this, GameEntity other)
			=> @this.position.Value == other.position.Value;
		
		public static bool GeneratorIs(this GameEntity @this, ItemName title)
			=> @this.generator.Value.Title == title;
	}
}