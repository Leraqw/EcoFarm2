using Entitas.CodeGeneration.Plugins;

namespace EcoFarmCustomGenerator.CodeGeneration.Plugins
{
	public static class MemberDataExtensions
	{
		public static bool IsFlagComponent(this MemberData[] memberData) => memberData.Length == 0;
	}
}