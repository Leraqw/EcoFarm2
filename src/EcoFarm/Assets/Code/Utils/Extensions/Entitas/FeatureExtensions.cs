namespace Code.Utils.Extensions.Entitas
{
	public static class FeatureExtensions
	{
		public static Feature ExecuteAnd(this Feature @this) => @this.Do((t) => t.Execute());
	}
}