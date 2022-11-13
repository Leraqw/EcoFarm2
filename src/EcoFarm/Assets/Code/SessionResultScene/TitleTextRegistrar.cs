using Code.PlayerContext.CustomTypes;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.SessionResultScene
{
	public class TitleTextRegistrar : MonoBehaviour
	{
		private static global::PlayerContext Context => Contexts.sharedInstance.player;

		private void Start()
			=> Context.CreateEntity()
			          .Do((e) => e.AddView(gameObject))
			          .Do((e) => e.AddText(GetTextByResult()));

		private static string GetTextByResult()
			=> Context.playerEntity.sessionResult.Value is SessionResult.Victory
				? "Victory!"
				: "You lose:(";
	}
}