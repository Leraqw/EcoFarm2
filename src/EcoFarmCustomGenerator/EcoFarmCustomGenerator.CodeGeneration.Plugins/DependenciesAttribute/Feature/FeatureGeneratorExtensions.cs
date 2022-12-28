using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins.Feature
{
	public static class FeatureGeneratorExtensions
	{
		public static string GetSystems(this IEnumerable<DependencyData> @this)
			=> string.Join("\n", @this.Select(GenerateSystemAdding));

		private static string GenerateSystemAdding(this DependencyData @this)
			=> $"\t\tAdd(new Resolve{@this.Name.RemoveComponentSuffix()}DependenciesSystem(contexts));";
	}
}