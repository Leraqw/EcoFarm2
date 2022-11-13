namespace Code.Services.Interfaces
{
	public interface ISceneTransferService : IService
	{
		void ToMainMenuScene();
		void ToGameplayScene();
		void ToGameResultScene();
	}
}