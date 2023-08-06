namespace EcoFarm
{
	public class FilledAuthoring : RegistrarBase
	{
		public override void Register(ref GameEntity entity) => entity.isFilled = true;
	}
}