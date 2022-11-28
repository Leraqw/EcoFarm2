using UnityEngine;
using static Code.Global.PlayerContexts.CustomTypes.SessionResult;

namespace Code.Unity.TEMP
{
	public class GameResultMenu : MonoBehaviour
	{
		[SerializeField] private GameObject _nextLevelButton;
		[SerializeField] private GameObject _retryLevelButton;

		private static PlayerEntity Player => Contexts.sharedInstance.player.currentPlayerEntity;

		private void Start()
		{
			var isVictory = Player.sessionResult.Value is Victory;

			_nextLevelButton.SetActive(isVictory);
			_retryLevelButton.SetActive(isVictory == false);
		}
	}
}