
using UnityEngine.SceneManagement;

namespace EcoFarm
{
	public class UnitySceneTransferService : ISceneTransferService
	{
		public void ToMainMenuScene() => SceneManager.LoadScene("MainMenuScene");

		public void ToGameplayScene() => SceneManager.LoadScene("GameplayScene");

		public void ToGameResultScene() => SceneManager.LoadScene("GameResultScene");
		public void ToLevelChoice() => SceneManager.LoadScene("LevelChoiseScene");
	}
}