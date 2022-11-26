using Newtonsoft.Json;

namespace Code.Data.StorageJson
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