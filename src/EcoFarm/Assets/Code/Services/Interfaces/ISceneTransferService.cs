
namespace EcoFarm
{
	public interface ISceneTransferService : IService
	{
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
		void ToLevelChoice();
	}
}