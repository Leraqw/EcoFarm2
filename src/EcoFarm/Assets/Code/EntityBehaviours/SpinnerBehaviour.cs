namespace Code.EntityBehaviours
{
	public class SpinnerBehaviour : EntityBehaviour
	{
		protected override bool ReadyForInitialization() => true;

		protected override void Initialize()
		{
			var e = Context.CreateEntity();
			e.AddDebugName("Windmill Rotation");
			e.isSpinner = true;
			e.AddRotationSpeed(1f);
			e.AddRotation(0);
			e.AddView(gameObject);
		}
	}
}