using UnityEngine.SceneManagement;

namespace Code.Services.Interfaces
{
	public interface ISceneTransferService : IService
	{
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
	}

	public class UnitySceneTransferService : ISceneTransferService
	{
		public void ToMainMenuScene()
		{
			SceneManager.LoadScene("MainMenuScene");
		}

		public void ToGameplayScene()
		{
			SceneManager.LoadScene("GameplayScene");
		}

		public void ToGameResultScene()
		{
			SceneManager.LoadScene("GameResultScene");
		}
	}
}