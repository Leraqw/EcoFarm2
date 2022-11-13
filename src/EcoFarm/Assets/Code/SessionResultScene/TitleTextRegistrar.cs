using Code.PlayerContext.CustomTypes;
using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.SessionResultScene
{
	public class TitleTextRegistrar : MonoBehaviour
	{
		[SerializeField] private TextView _textListener;

		private static global::PlayerContext Context => Contexts.sharedInstance.player;

		private void Start()
			=> Context.CreateEntity()
			          .Do((e) => e.AddText(GetTextByResult()))
			          .Do((e) => e.AddPlayerTextListener(_textListener))
			          .Do((e) => e.isDestroy = true);

		private static string GetTextByResult()
			=> Context.playerEntity.sessionResult.Value is SessionResult.Victory
				? "Victory!"
				: "You lose:(";
	}
}