namespace Code.EntityBehaviours
{
	public class SpinnerBehaviour : EntityBehaviour
	{
		protected override bool ReadyForInitialization() => true;

		protected override void Initialize()
		{
			var entity = Context.CreateEntity();
			entity.isSpinner = true;
			entity.AddRotationSpeed(1f);
		}
	}
}