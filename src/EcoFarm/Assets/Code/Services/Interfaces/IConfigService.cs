namespace Code.Services.Interfaces
{
	public interface IConfigService : IService
	{
		int TreesCount { get; }
		
		IConfigService Default { get; }
	}
}