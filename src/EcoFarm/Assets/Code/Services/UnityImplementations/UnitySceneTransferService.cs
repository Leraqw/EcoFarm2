using Code.Services.Interfaces;
using Code.Unity.CustomTypes;
using UnityEngine.SceneManagement;

namespace Code.Services.UnityImplementations
{
	public class UnitySceneTransferService : ISceneTransferService
	{
		public void ToMainMenuScene() => SceneManager.LoadScene("MainMenuScene");

		public void ToGameplayScene() => SceneManager.LoadScene("GameplayScene");

		public void ToGameResultScene() => SceneManager.LoadScene("GameResultScene");
		public void ToScene(SceneField scene) => SceneManager.LoadScene(scene);
	}
}