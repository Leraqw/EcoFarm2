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
			Console.WriteLine(type.GetName());
			Console.WriteLine($"value: {type.Value}");
			var baseType = ((INamedTypeSymbol)type.Value).BaseType;
			Console.WriteLine($"base type: {baseType}");
			Console.WriteLine($"base type name: {baseType.Name}");
			var fields = baseType.GetMembers().OfType<IFieldSymbol>().Select((f) => f.Name).ToArray();
			Console.WriteLine($"any field: {fields.Any()}");
			Console.WriteLine($"base type fields: {string.Join("👌️ ", fields)}");
			
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