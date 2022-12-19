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
	public class CoolDataProvider : IDataProvider, IConfigurable, ICachable
	{
		private readonly ProjectPathConfig _projectPathConfig = new ProjectPathConfig();

		public string name         => "Cool";
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
			   .Where((t) => t.GetAttribute<CoolAttribute>() != null)
			   .Select
			   (
				   (t) => new CoolData
				   {
					   Name = t.Name,
					   MemberData = GetData(t),
				   }
			   )
			   .ToArray();

		private MemberData[] GetData(INamedTypeSymbol type)
			=> type.GetMembers()
			       .OfType<IFieldSymbol>()
			       .Select((f) => new MemberData(f.Type.ToCompilableString(), f.Name))
			       .ToArray();
	}
}