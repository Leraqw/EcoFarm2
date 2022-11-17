namespace Code.Utils.Extensions.Entitas
{
	public static class BuildingsExtensions
	{
		public static bool HasSamePosition(this GameEntity @this, GameEntity other)
			=> @this.position.Value == other.position.Value;
	}
}