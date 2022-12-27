using System.Collections.Generic;
using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using DesperateDevs.Utils;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class ResolveDependenciesSystemGenerator : ICodeGenerator
	{
		private const string DirectoryName = "DependenciesSystems";

		public string name         => "Dependency";
		public int    priority     => 0;
		public bool   runInDryMode => true;

		public CodeGenFile[] Generate(CodeGeneratorData[] data)
			=> data
			   .OfType<DependencyData>()
			   .Select(DataToSystem)
			   .ToArray();

		private CodeGenFile DataToSystem(DependencyData data)
		{
			var componentName = data.Name.ToComponentName(ignoreNamespaces: true);
			var fileName = Path.Combine(DirectoryName, $"{componentName}DependenciesSystem.cs");
			var generatorName = GetType().FullName;

			var fileContent = Template.System
			(
				component: componentName,
				context: data.Context,
				resolving: Resolving(data.Dependencies),
				isFlag: data.MemberData.ToArray().Any() == false
			);

			return new CodeGenFile(fileName, fileContent, generatorName);
		}

		private static string Resolving(IEnumerable<string> dependencies)
			=> string.Join("\n", dependencies.Select(Template.ResolveDependency));

		private static class Template
		{
			public static string System(string component, string context, string resolving, bool isFlag)
				=> $@"
using System.Collections.Generic;
using Entitas;

public sealed class Resolve{component}DependenciesSystem : ReactiveSystem<{context}Entity>
{{
	public Resolve{component}DependenciesSystem(Contexts contexts) : base(contexts.{context.LowercaseFirst()}) {{ }}

	protected override ICollector<{context}Entity> GetTrigger(IContext<{context}Entity> context)
		=> context.CreateCollector({context}Matcher.{component});

	protected override bool Filter({context}Entity entity) => entity.{(isFlag ? "is" : "has")}{component};

	protected override void Execute(List<{context}Entity> entites)
	{{
		foreach (var e in entites)
		{{
{resolving}
		}}
	}}
}}";

			public static string ResolveDependency(string member)
				=> $"\t\t\t{member};";
		}
	}
}