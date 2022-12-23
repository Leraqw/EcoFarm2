using System;
using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class ResolveDependencySystemGenerator : ICodeGenerator
	{
		private const string DirectoryName = "DependenciesSystems";

		public string name         => "Dependency";
		public int    priority     => 0;
		public bool   runInDryMode => true;

		public CodeGenFile[] Generate(CodeGeneratorData[] data)
			=> data
			   .OfType<DependencyData>()
			   .Select(GenerateInner)
			   .ToArray();

		private CodeGenFile GenerateInner(DependencyData data)
		{
			var componentName = data.Name.ToComponentName(true);
			var className = $"{componentName}DependenciesSystem";
			var fileName = Path.Combine(DirectoryName, $"{className}.cs");

			var memberData = data.MemberData;
			throw new NotImplementedException();
		}
	}
}