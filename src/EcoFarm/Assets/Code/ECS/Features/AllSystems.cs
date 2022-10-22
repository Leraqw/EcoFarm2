namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(Contexts contexts)
			: base(nameof(AllSystems)) { }

		public void Tick()
		{
			Execute();
			Cleanup();
		}
	}
}