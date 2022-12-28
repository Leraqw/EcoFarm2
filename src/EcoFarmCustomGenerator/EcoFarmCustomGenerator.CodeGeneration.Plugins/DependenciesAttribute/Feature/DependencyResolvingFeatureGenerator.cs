using System.Collections.Generic;
using System.Linq;
using DesperateDevs.CodeGeneration;

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
			   .Aggregate(new Dictionary<string, List<DependencyData>>(), GetComponentsByContexts)
			   .Select(AsFile)
			   .ToArray();

		private static Dictionary<string, List<DependencyData>> GetComponentsByContexts
			(Dictionary<string, List<DependencyData>> dictionary, DependencyData data)
			=> dictionary.GetComponentsByContext(data);

		private CodeGenFile AsFile(KeyValuePair<string, List<DependencyData>> p) => DataToFeature(p.Key, p.Value);

		private CodeGenFile DataToFeature(string contextName, IEnumerable<DependencyData> data)
			=> new CodeGenFile
			(
				contextName.FileName(),
				Template.Feature(contextName, data.GetSystems()),
				GetType().FullName
			);

		private static class Template
		{
			public static string Feature(string contextName, string systemsList)
				=> $@"
public sealed class {contextName}CleanupSystems : Feature 
{{
    public {contextName}CleanupSystems(Contexts contexts)
		: base(nameof({contextName}CleanupSystems))
	{{
{systemsList}
    }}
}}
";
		}
	}
}