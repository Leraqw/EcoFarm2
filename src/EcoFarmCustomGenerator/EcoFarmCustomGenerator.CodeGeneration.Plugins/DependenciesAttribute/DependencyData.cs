using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class DependencyData : CodeGeneratorData
	{
		public string NameKey = "Dependency.Name";
		public string MemberKey = "Dependency.Members";
		public string DependenciesKey = "Dependency.Dependencies";

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

		public string[] Dependencies
		{
			get => (string[])this[DependenciesKey];
			set => this[DependenciesKey] = value;
		}
	}
}