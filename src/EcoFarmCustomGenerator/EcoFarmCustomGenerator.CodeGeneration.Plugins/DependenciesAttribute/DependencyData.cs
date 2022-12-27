using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class DependencyData : CodeGeneratorData
	{
		private const string NameKey = "Dependency.Name";
		private const string MemberKey = "Dependency.Members";
		private const string DependenciesKey = "Dependency.Dependencies";
		private const string ContextKey = "Dependency.Context";

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
		
		public string Context
		{
			get => (string)this[ContextKey];
			set => this[ContextKey] = value;
		}
	}
}