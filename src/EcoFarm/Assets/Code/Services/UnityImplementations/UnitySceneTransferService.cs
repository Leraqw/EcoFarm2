using UnityEngine.SceneManagement;
using static EcoFarm.Constants.SceneName;

namespace EcoFarm
{
	public class UnitySceneTransferService : ISceneTransferService
	{
		public void ToBootstrapScene()  => SceneManager.LoadScene(BootstrapScene);
		public void ToMainMenuScene()   => SceneManager.LoadScene(MainMenuScene);
		public void ToGameplayScene()   => SceneManager.LoadScene(GameplayScene);
		public void ToGameResultScene() => SceneManager.LoadScene(GameResultScene);
		public void ToLevelChoice()     => SceneManager.LoadScene(LevelChoiseScene);
	}
}