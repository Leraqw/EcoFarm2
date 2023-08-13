namespace EcoFarm
{
	public class FilledAuthoring : AuthoringBase
	{
		public override void Register(ref GameEntity entity) => entity.isFilled = true;
	}
}