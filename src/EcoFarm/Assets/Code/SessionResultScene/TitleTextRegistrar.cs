using UnityEngine;
using Zenject;
using static EcoFarm.SessionResult;

namespace EcoFarm
{
	public class TitleTextRegistrar : StartEntityBehaviour
	{
		[SerializeField] private TextView _textListener;

		private PlayerEntity.Factory _playerEntityFactory;

		[Inject]
		public void Construct(PlayerEntity.Factory playerEntityFactory)
			=> _playerEntityFactory = playerEntityFactory;

		private static PlayerContext Context => Contexts.player;

		private static string TextByResult
			=> Context.currentPlayerEntity.sessionResult.Value is Victory
				? "Победа!"
				: "Поражение:(";

		protected override void Initialize()
		{
			var e = _playerEntityFactory.Create();
			e.AddText(TextByResult);
			e.AddPlayerTextListener(_textListener);
			e.isDestroy = true;
		}
	}
}