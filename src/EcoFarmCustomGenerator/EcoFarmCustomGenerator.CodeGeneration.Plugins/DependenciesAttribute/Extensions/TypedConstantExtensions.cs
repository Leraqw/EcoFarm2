using System.Collections.Generic;
using System.Linq;
using Entitas;
using Microsoft.CodeAnalysis;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class TypedConstantExtensions
	{
		public static string Resolve(TypedConstant type)
			=> ResolveByType(type.GetComponentName(), type.IsFlagComponent());

		private static string ResolveByType(string component, bool isFlag)
			=> isFlag
				? $"is{component} = true"
				: $"Add{component}(default)";

		private static string GetComponentName(this TypedConstant type) => type.GetName().RemoveComponentSuffix();
		private static bool IsFlagComponent(this TypedConstant type) => type.BaseType().GetFields().Any() == false;

		private static INamedTypeSymbol BaseType(this TypedConstant type) => type.NamedType().BaseType;

		private static IEnumerable<IFieldSymbol> GetFields(this INamespaceOrTypeSymbol type)
			=> type.GetMembers().OfType<IFieldSymbol>();

		private static string GetName(this TypedConstant typedConstant) => typedConstant.NamedType().Name;

		private static INamedTypeSymbol NamedType(this TypedConstant typedConstant)
			=> (INamedTypeSymbol)typedConstant.Value;
	}
}