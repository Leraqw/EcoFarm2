namespace EcoFarm
{
	public class DraggableAuthoring : AuthoringBase
	{
		public override void Register(ref GameEntity entity) => entity.isDraggable = true;
	}
}