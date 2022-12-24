using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class DependencyData : ComponentData
	{
		public const string NameKey = "Dependency.Name";
		public const string MemberKey = "Dependency.Members";
		public const string DependenciesKey = "Dependency.Dependencies";

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