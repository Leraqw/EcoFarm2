namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class ComponentClass
	{
		public string Name   { get; set; }
		public bool   IsFlag { get; set; }

		public ComponentClass(string name, bool isFlag)
		{
			Name = name;
			IsFlag = isFlag;
		}
	}
}