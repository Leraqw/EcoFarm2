using System.Collections.Generic;

namespace EcoFarm
{
	public static class AttachExtensions
	{
		private static GameContext Context => Contexts.sharedInstance.game;

		public static GameEntity AttachTo(this GameEntity @this, GameEntity attachable) 
			=> @this.Do((e) => e.ReplaceAttachedTo(attachable.attachableIndex.Value));

		public static GameEntity AttachToMe(this GameEntity @this, GameEntity attached) 
			=> @this.Do((e) => attached.AttachTo(e));

		public static GameEntity MakeAttachable(this GameEntity @this) 
			=> @this.Do((e) => e.AddAttachableIndex(@this.creationIndex));

		public static IEnumerable<GameEntity> GetAttachedEntities(this GameEntity @this)
			=> Context.GetEntitiesWithAttachedTo(@this.attachableIndex.Value);
		
		public static GameEntity GetAttachableEntity(this GameEntity @this)
			=> Context.GetEntityWithAttachableIndex(@this.attachedTo.Value);
	}
}