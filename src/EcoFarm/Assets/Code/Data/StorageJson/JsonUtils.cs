using Newtonsoft.Json;

namespace EcoFarm
{
	public static class JsonUtils
	{
		public static JsonSerializerSettings WithReferences => new()
		{
			PreserveReferencesHandling = PreserveReferencesHandling.Objects,
			TypeNameHandling = TypeNameHandling.All,
		};
	}
}