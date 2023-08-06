namespace EcoFarm
{
	public class BucketAuthoring : RegistrarBase
	{
		public override void Register(ref GameEntity entity) => entity.isBucket = true;
	}
}