namespace Code.Data
{
	public interface IStorage
	{
		void Save<T>(T data);
		T Load<T>(T defaultValue);
	}
}