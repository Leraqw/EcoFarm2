
namespace EcoFarm
{
	public interface ISceneTransferService : IService
	{
		void ToBootstrapScene();
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
		void ToLevelChoice();
	}
}