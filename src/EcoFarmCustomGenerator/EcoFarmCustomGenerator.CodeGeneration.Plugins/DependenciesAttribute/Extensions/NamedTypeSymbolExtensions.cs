using System.Linq;
using DesperateDevs.Roslyn;
using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Plugins;
using Microsoft.CodeAnalysis;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class NamedTypeSymbolExtensions
	{
		public static string GetContext(this INamedTypeSymbol namedTypeSymbol)
			=> namedTypeSymbol.GetAttribute<ContextAttribute>()?.ConstructorArguments[0].Value.ToString();

		public static MemberData[] GetData(this INamedTypeSymbol type)
			=> type.GetMembers()
			       .OfType<IFieldSymbol>()
			       .Select((f) => new MemberData(f.Type.ToCompilableString(), f.Name))
			       .ToArray();

		public static string[] GetDependencies(this INamedTypeSymbol type)
			=> type.GetAttribute<DependenciesAttribute>()
			       .ConstructorArguments[0]
			       .Values.Select((v) => v.GetName())
			       .ToArray();

		private static string GetName(this TypedConstant typedConstant) => ((INamedTypeSymbol)typedConstant.Value).Name;

		private static bool IsContainMembers(this TypedConstant typedConstant)
			=> typedConstant.Value.GetType().GetFields().Any();
	}
}