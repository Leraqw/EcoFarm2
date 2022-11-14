// ReSharper disable FieldCanBeMadeReadOnly.Global - for Unity Serialization
namespace Code.ECS.Components.ComplexComponentTypes
{
	public class Item
	{
		public string Name;
		public int Count;

		public Item(string name)
		{
			Name = name;
			Count = 0;
		}
	}
}