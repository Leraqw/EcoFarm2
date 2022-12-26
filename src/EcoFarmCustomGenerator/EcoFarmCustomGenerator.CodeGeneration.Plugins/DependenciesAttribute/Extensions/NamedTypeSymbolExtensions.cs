using System;
using System.Linq;
using DesperateDevs.Roslyn;
using EcoFarmCustomGenerator.CodeGeneration.Attributes;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using Entitas.CodeGeneration.Plugins;
using Microsoft.CodeAnalysis;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class NamedTypeSymbolExtensions
	{
		public static string GetContext(this INamedTypeSymbol type)
			=> type.GetAttributes()
			       .Select((ad) => ad.AttributeClass)
			       .Single((a) => a.BaseType.Name == nameof(ContextAttribute))
			       .Name.RemoveAttributeSuffix();

		private static string RemoveAttributeSuffix(this string @this)
			=> @this.EndsWith("Attribute") ? @this.Substring(0, @this.Length - "Attribute".Length) : @this;

		public static MemberData[] GetData(this INamedTypeSymbol type)
			=> type.GetMembers()
			       .OfType<IFieldSymbol>()
			       .Select((f) => new MemberData(f.Type.ToCompilableString(), f.Name))
			       .ToArray();

		public static string[] GetDependencies(this INamedTypeSymbol type)
			=> type.GetAttribute<DependenciesAttribute>()
			       .ConstructorArguments[0]
			       .Values.Select(Resolve)
			       .ToArray();

		private static string Resolve(TypedConstant type)
		{
			// print type name
			Console.WriteLine(type.GetName().RemoveComponentSuffix());
			
			Console.WriteLine($"full:  {((INamedTypeSymbol)type.Value).BaseType.GetMembers().OfType<IFieldSymbol>().Select((f) => f.Name).ToArray().Any()}");
			Console.WriteLine($"short: {((INamedTypeSymbol)type.Value).BaseType.GetMembers().OfType<IFieldSymbol>().Any()}");
			Console.WriteLine($"count: {((INamedTypeSymbol)type.Value).BaseType.GetMembers().OfType<IFieldSymbol>().Count()}");
			
			Console.WriteLine();

			return type.Type.BaseType.Name == "FlagComponent"
				? $"is{type.GetName().RemoveComponentSuffix()} = true"
				: $"Add{type.GetName().RemoveComponentSuffix()}(default)";
		}

		private static string GetName(this TypedConstant typedConstant) => ((INamedTypeSymbol)typedConstant.Value).Name;

		private static bool IsContainMembers(this TypedConstant typedConstant)
			=> typedConstant.Value.GetType().GetFields().Any();
	}
}