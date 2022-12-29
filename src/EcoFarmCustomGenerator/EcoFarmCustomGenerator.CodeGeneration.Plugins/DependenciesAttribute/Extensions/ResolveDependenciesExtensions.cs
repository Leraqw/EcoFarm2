using System.Collections.Generic;
using System.Linq;
using Entitas;
using Microsoft.CodeAnalysis;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class ResolveDependenciesExtensions
	{
		public static string Resolve(TypedConstant @this)
			=> ResolveByType(@this.GetComponentName(), @this.IsFlagComponent());

		private static string ResolveByType(string component, bool isFlag)
			=> isFlag
				? $"e.is{component} = true"
				: $"if (!e.has{component}) e.Add{component}(default)";

		private static string GetComponentName(this TypedConstant @this) => @this.Name().RemoveComponentSuffix();

		private static bool IsFlagComponent(this TypedConstant @this) => @this.BaseType().Fields().Any() == false;

		private static INamedTypeSymbol BaseType(this TypedConstant @this) => @this.NamedType().BaseType;

		private static IEnumerable<IFieldSymbol> Fields(this INamespaceOrTypeSymbol @this)
			=> @this.GetMembers().OfType<IFieldSymbol>();

		private static string Name(this TypedConstant @this) => @this.NamedType().Name;

		private static INamedTypeSymbol NamedType(this TypedConstant @this) => (INamedTypeSymbol)@this.Value;
	}
}