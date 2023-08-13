namespace EcoFarm
{
	public static class FeatureExtensions
	{
		public static Feature ExecuteAnd(this Feature @this)
		{
			@this.Execute();
			return @this;
		}
	}
}