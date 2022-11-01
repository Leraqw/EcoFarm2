namespace Code.ECS.Components.ComplexComponentTypes
{
	public class Item
	{
		public string Name;
		public int Count;
		
		public static implicit operator Item((string name, int count) tuple)
			=> new() { Name = tuple.name, Count = tuple.count };
	}
}