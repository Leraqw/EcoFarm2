using System;
using System.Collections.Generic;
using System.Linq;
using DesperateDevs.CodeGeneration;
using DesperateDevs.CodeGeneration.Plugins;
using DesperateDevs.Roslyn;
using DesperateDevs.Serialization;
using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Plugins;
using Microsoft.CodeAnalysis;
using PluginUtil = DesperateDevs.Roslyn.CodeGeneration.Plugins.PluginUtil;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class DependencyDataProvider : IDataProvider, IConfigurable, ICachable
	{
		private readonly ProjectPathConfig _projectPathConfig = new ProjectPathConfig();

		public string name         => "Dependency";
		public int    priority     => 0;
		public bool   runInDryMode => true;

		public Dictionary<string, string> defaultProperties => _projectPathConfig.defaultProperties;
		public Dictionary<string, object> objectCache       { get; set; }

		public void Configure(Preferences preferences) => _projectPathConfig.Configure(preferences);

		// ReSharper disable once CoVariantArrayConversion - this is a Roslyn API
		public CodeGeneratorData[] GetData()
			=> PluginUtil
			   .GetCachedProjectParser(objectCache, _projectPathConfig.projectPath)
			   .GetTypes()
			   .Where((t) => t.HasAttribute<DependenciesAttribute>())
			   .Select(AsDependencyData)
			   .ToArray();

		private static DependencyData AsDependencyData(INamedTypeSymbol type)
		{
			Console.WriteLine(type.Name);
			PrintArray(type.BaseType.GetData());
			Console.WriteLine();

			return new DependencyData
			{
				Name = type.Name,
				MemberData = type.BaseType.GetData(),
				Dependencies = type.GetDependencies(),
				Context = type.GetContext(),
			};
		}

		private static void PrintArray<T>(IEnumerable<T> memberData)
			=> Console.WriteLine(string.Join(", ", memberData));
	}
}