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
		public static bool HasAttribute<T>(this INamedTypeSymbol @this)
			=> @this.GetAttribute<T>() != null;

		private static string RemoveAttributeSuffix(this string @this)
			=> @this.EndsWith("Attribute") ? @this.Substring(0, @this.Length - "Attribute".Length) : @this;

		public static string GetContext(this INamedTypeSymbol @this)
			=> @this.GetAttributes()
			       .Select((ad) => ad.AttributeClass)
			       .Single((a) => a.BaseType.Name == nameof(ContextAttribute))
			       .Name.RemoveAttributeSuffix();

		public static MemberData[] GetData(this INamedTypeSymbol @this)
			=> @this.GetMembers()
			       .OfType<IFieldSymbol>()
			       .Select((f) => new MemberData(f.Type.ToCompilableString(), f.Name))
			       .ToArray();

		public static string[] GetDependencies(this INamedTypeSymbol @this)
			=> @this.GetAttribute<DependenciesAttribute>()
			       .ConstructorArguments[0]
			       .Values.Select(ResolveDependenciesExtensions.Resolve)
			       .ToArray();
	}
}