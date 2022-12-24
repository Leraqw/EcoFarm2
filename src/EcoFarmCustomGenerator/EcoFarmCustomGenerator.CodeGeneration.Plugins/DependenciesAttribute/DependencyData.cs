using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class DependencyData : ComponentData
	{
		private const string NameKey = "Dependency.Name";
		private const string MemberKey = "Dependency.Members";
		private const string DependenciesKey = "Dependency.Dependencies";

		public string Context { get; set; }

		public string Name
		{
			get => (string)this[NameKey];
			set => this[NameKey] = value;
		}

		public MemberData[] MemberData
		{
			get => (MemberData[])this[MemberKey];
			set => this[MemberKey] = value;
		}

		public ComponentClass[] Dependencies
		{
			get => (ComponentClass[])this[DependenciesKey];
			set => this[DependenciesKey] = value;
		}
	}
}