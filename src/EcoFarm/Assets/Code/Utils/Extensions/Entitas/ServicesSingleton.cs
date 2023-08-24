using Zenject;

namespace EcoFarm
{
	/// <summary> Cringy solution to make extensions work </summary>
	public class ServicesSingleton
	{
		private static ServicesSingleton _instance;
		private ServicesSingleton() { }

		public static ServicesSingleton Instance => _instance ??= new ServicesSingleton();

		[Inject] public SystemsFactory        SystemsFactory { get; }
		[Inject] public IConfigurationService Configuration  { get; }
		[Inject] public ISceneTransferService SceneTransfer  { get; }
	}
}