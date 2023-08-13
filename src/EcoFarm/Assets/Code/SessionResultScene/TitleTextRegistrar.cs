using UnityEngine;
using static EcoFarm.SessionResult;

namespace EcoFarm
{
	public class TitleTextRegistrar : StartEntityBehaviour
	{
		[SerializeField] private TextView _textListener;

		private static PlayerContext Context => Contexts.player;

		private static string TextByResult
			=> Context.currentPlayerEntity.sessionResult.Value is Victory
				? "Победа!"
				: "Поражение:(";

		protected override void Initialize()
		{
			var e = Context.CreateEntity();
			e.AddText(TextByResult);
			e.AddPlayerTextListener(_textListener);
			e.isDestroy = true;
		}
	}
}