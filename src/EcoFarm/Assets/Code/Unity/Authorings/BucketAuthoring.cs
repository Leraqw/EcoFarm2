namespace EcoFarm
{
	public class BucketAuthoring : AuthoringBase
	{
		public override void Register(ref GameEntity entity) => entity.isBucket = true;
	}
}