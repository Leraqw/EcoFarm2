using System.IO;
using System.Linq;
using DesperateDevs.CodeGeneration;
using DesperateDevs.Utils;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class CoolGenerator : ICodeGenerator
	{
		private const string DirectoryName = "CoolStuff";

		public string name         => "Cool";
		public int    priority     => 0;
		public bool   runInDryMode => true;

		public CodeGenFile[] Generate(CodeGeneratorData[] data)
			=> data
			   .OfType<CoolData>()
			   .Select(GenerateInner)
			   .ToArray();

		private CodeGenFile GenerateInner(CoolData data)
		{
			var componentName = data.Name.ToComponentName(ignoreNamespaces: true);
			var className = $"{componentName}Script";
			var fileName = Path.Combine(DirectoryName, $"{className}.cs");

			var memberData = data.MemberData;
			var template = IsFlagComponent(memberData)
				? Template.FlagComponent
				: Template.ValueComponent;

			var fileContent = template
			                  .Replace("${ClassName}", className)
			                  .Replace("${ComponentName}", componentName)
			                  .Replace("${Fields}", GenerateFields(memberData))
			                  .Replace("${Args}", GenerateArgs(memberData));

			return new CodeGenFile(fileName, fileContent, GetType().FullName);
		}

		private static bool IsFlagComponent(MemberData[] memberData) => memberData.ToArray().Length == 0;

		private string GenerateFields(MemberData[] data) => Generate(data, "\n", Template.Field);

		private string GenerateArgs(MemberData[] data) => Generate(data, ", ", Template.Argument);

		private static string Generate(MemberData[] data, string separator, string template)
			=> string.Join(separator, data.Select((m) => Format(template, m)).ToArray());

		private static string Format(string template, MemberData member)
			=> template.Replace("${FieldType}", member.type)
			           .Replace("${fieldName}", member.name.LowercaseFirst())
			           .Replace("${FieldName}", member.name);

		private static class Template
		{
			public const string ValueComponent =
				@"using UnityEngine;

public class ${ClassName} : MonoBehaviour
{
${Fields}

	public void Initialize(GameEntity entity)
	{
		entity.Replace${ComponentName}(${Args});
	}
}
";

			public const string FlagComponent =
				@"using UnityEngine;

public class ${ClassName} : MonoBehaviour
{
	public void Initialize(GameEntity entity)
	{
		entity.is${ComponentName} = true;
	}
}
";

			public const string Field = "\t[SerializeField] private ${FieldType} _${fieldName};";
			public const string Argument = "${fieldName}";
		}
	}
}