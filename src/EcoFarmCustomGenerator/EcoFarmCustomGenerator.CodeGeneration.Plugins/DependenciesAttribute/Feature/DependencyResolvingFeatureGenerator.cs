﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using Entitas;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins.Feature
{
	public class DependencyResolvingFeatureGenerator : ICodeGenerator
	{
		public string name         => "DependencyFeature";
		public int    priority     => 0;
		public bool   runInDryMode => true;

		public CodeGenFile[] Generate(CodeGeneratorData[] data)
			=> data
			   .OfType<DependencyData>()
			   .ToLookup((d) => d.Context)
			   .Select(AsFile)
			   .ToArray();

		private CodeGenFile AsFile(IGrouping<string, DependencyData> p) => DataToFeature(p.Key, p.ToList());

		private CodeGenFile DataToFeature(string contextName, IEnumerable<DependencyData> data)
		{
			var className = $"{contextName}DependenciesFeature";
			return new CodeGenFile
			(
				Path.Combine(contextName, $"{className}.cs"),
				Template.Feature(className, SystemsAdding(data)),
				GetType().FullName
			);
		}

		private static string SystemsAdding(IEnumerable<DependencyData> data)
			=> string.Join("\n", data.Select((d) => Template.AddSystem(d.Name.RemoveComponentSuffix())));

		private static class Template
		{
			public static string Feature(string className, string systemsList)
				=> $@"
public sealed class {className} : Feature 
{{
    public {className}(Contexts contexts)
		: base(nameof({className}))
	{{
{systemsList}
    }}
}}
";

			public static string AddSystem(string componentName)
				=> $"\t\tAdd(new Resolve{componentName}DependenciesSystem(contexts));";
		}
	}
}