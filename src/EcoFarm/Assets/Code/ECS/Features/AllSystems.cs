namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		private AllSystems(Contexts contexts)
			: base(nameof(AllSystems)) { }

		public static AllSystems Create() => new(Contexts.sharedInstance);

		public void OnUpdate()
		{
			Execute();
			Cleanup();
		}
	}
}