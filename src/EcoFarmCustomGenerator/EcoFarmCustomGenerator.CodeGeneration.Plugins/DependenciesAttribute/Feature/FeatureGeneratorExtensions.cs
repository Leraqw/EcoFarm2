using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins.Feature
{
	public static class FeatureGeneratorExtensions
	{
		public static string FileName(this string @this)
			=> Path.Combine(@this, $"{@this}CleanupSystems.cs");

		public static string GetSystems(this IEnumerable<DependencyData> @this)
			=> string.Join("\n", @this.Select(GenerateSystemAdding));

		private static string GenerateSystemAdding(this DependencyData @this)
			=> $"\t\tAdd(new Resolve{@this.Name.ToComponentName(ignoreNamespaces: true)}DependenciesSystem(contexts));";

		public static Dictionary<string, List<DependencyData>> GetComponentsByContext
			(this Dictionary<string, List<DependencyData>> @this, DependencyData data)
		{
			AddIfNotContain(@this, data.Context);
			@this[data.Context].Add(data);
			return @this;
		}

		private static void AddIfNotContain(this IDictionary<string, List<DependencyData>> @this, string contextName)
		{
			if (@this.ContainsKey(contextName) == false)
			{
				@this.Add(contextName, new List<DependencyData>());
			}
		}
	}
}