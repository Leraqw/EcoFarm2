using UnityEngine;
using static Code.SessionResult;

namespace Code
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
				? "Победа!"
				: "Поражение:(";
	}
}