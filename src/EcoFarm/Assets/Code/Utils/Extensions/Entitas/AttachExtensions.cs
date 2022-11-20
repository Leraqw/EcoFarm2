namespace Code.Utils.Extensions.Entitas
{
	public static class AttachExtensions
	{
		public static GameEntity AttachTo(this GameEntity @this, GameEntity attachable) 
			=> @this.Do((e) => e.AddAttachedTo(attachable.attachableIndex));
		
		public static GameEntity AttachToMe(this GameEntity @this, GameEntity attached) 
			=> @this.Do((e) => attached.AttachTo(e));

		public static GameEntity AddAttachableIndex(this GameEntity @this) 
			=> @this.Do((e) => e.AddAttachableIndex(@this.creationIndex));
	}
}