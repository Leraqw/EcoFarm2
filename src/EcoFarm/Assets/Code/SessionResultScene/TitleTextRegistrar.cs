using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;
using static Code.Global.PlayerContexts.CustomTypes.SessionResult;

namespace Code.SessionResultScene
{
	public class TitleTextRegistrar : MonoBehaviour
	{
		[SerializeField] private TextView _textListener;

		private static PlayerContext Context => Contexts.sharedInstance.player;

		private void Start()
			=> Context.CreateEntity()
			          .Do((e) => e.AddText(GetTextByResult()))
			          .Do((e) => e.AddPlayerTextListener(_textListener))
			          .Do((e) => e.isDestroy = true);

		private static string GetTextByResult()
			=> Context.currentPlayerEntity.sessionResult.Value is Victory
				? "Victory!"
				: "You lose:(";
	}
}