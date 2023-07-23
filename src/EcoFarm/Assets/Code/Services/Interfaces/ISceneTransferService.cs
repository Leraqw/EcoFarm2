
namespace Code
{
	public interface ISceneTransferService : IService
	{
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
		void ToLevelChoice();
	}
}