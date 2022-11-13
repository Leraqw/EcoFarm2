using Code.Unity.CustomTypes;

namespace Code.Services.Interfaces
{
	public interface ISceneTransferService : IService
	{
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
		void ToScene(SceneField scene);
	}
}