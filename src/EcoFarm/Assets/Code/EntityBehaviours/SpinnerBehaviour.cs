namespace Code
{
	public class SpinnerBehaviour : EntityBehaviour
	{
		protected override bool ReadyForInitialization() => true;

		protected override void Initialize()
		{
			var e = Contexts.game.CreateEntity();
			e.AddDebugName("Windmill Rotation");
			e.isSpinner = true;
			e.AddRotationSpeed(1f);
			e.AddRotation(0);
			e.AddView(gameObject);
		}
	}
}