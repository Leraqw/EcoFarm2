using SQLite;

namespace DataAdministration
{
	public static class SqLiteConnectionExtensions
	{
		public static void Insert<T>(this SQLiteConnection @this, T item) => @this.Insert(item, typeof(T));
	}
}