namespace Code
{
	public class DraggableAuthoring : RegistrarBase
	{
		public override void Register(ref GameEntity entity) => entity.isDraggable = true;
	}
}