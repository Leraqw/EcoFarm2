using Code.Services.Interfaces;
using UnityEngine.SceneManagement;

namespace Code.Services.UnityImplementations
{
	public class UnitySceneTransferService : ISceneTransferService
	{
		public void ToMainMenuScene() => SceneManager.LoadScene("MainMenuScene");

		public void ToGameplayScene() => SceneManager.LoadScene("GameplayScene");

		public void ToGameResultScene() => SceneManager.LoadScene("GameResultScene");
		public void ToLevelChoice() => SceneManager.LoadScene("LevelChoiseScene");
	}
}