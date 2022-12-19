using DesperateDevs.CodeGeneration;
using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public class CoolData : CodeGeneratorData
	{
		public const string NameKey = "Cool.Name";
		public const string DataKey = "Cool.Data";

		public string Name
		{
			get => (string)this[NameKey];
			set => this[NameKey] = value;
		}

		public MemberData[] MemberData
		{
			get => (MemberData[])this[DataKey];
			set => this[DataKey] = value;
		}
	}
}