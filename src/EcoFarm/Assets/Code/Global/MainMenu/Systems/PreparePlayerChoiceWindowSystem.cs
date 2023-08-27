using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using UnityEngine.UI;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PreparePlayerChoiceWindowSystem : ReactiveSystem<GameEntity>
	{
		private readonly IDataProviderService _dataProvider;
		private readonly GameEntity.Factory _gameEntityFactory;
		private readonly Injector _injector;

		public PreparePlayerChoiceWindowSystem
		(
			Contexts contexts,
			IDataProviderService dataProvider,
			GameEntity.Factory gameEntityFactory,
			Injector injector
		)
			: base(contexts.game)
		{
			_dataProvider = dataProvider;
			_gameEntityFactory = gameEntityFactory;
			_injector = injector;
		}

		private IEnumerable<Player> Players => _dataProvider.PlayersList.Players;

		private PlayerView PlayerViewPrefab => _dataProvider.PlayerView;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(PlayerChoiceWindow, Toggled, RequirePreparation));

		protected override bool Filter(GameEntity entity) => entity.isToggled && entity.isRequirePreparation;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Prepare);

		private void Prepare(GameEntity window)
			=> window.Do(CleanPlayerList)
			         .Do(FillPlayerList)
			         .Do(EndPreparations);

		private static void CleanPlayerList(GameEntity window)
			=> window.GetAttachedEntities()
			         .Do((entities) => entities.ForEach((e) => e.isDestroy = true))
			         .Do((entities) => entities.ForEach((e) => e.viewPrefab.Value.DestroyGameObject()));

		private void FillPlayerList(GameEntity window)
			=> Players.ForEach((player) => BindPlayerChoiceView(player, PlayerViewPrefab, window));

		private void BindPlayerChoiceView(Player player, BaseViewListener prefab, GameEntity window)
		{
			var e = _gameEntityFactory.Create();
			var viewPrefab = Object.Instantiate(prefab, window.playerWindowContent.Value);
			_injector.InjectGameObject(viewPrefab.gameObject);

			e.AddPlayerToChoose(player);
			viewPrefab.Register(e);
			e.AttachTo(window);
			e.AddDebugName($"playerItem_{player.Nickname}");
			e.AddViewPrefab(viewPrefab.gameObject);

			ReplaceModeButtons(e);
		}

		private static void ReplaceModeButtons(GameEntity e)
		{
			var enabled = new EnabledReceivers
			{
				PlayerToChoose = true,
				PlayerToEdit = false
			};

			var colorBlock = new ColorBlock
			{
				normalColor = Color.white,
				highlightedColor = Color.white,
				pressedColor = Color.white,
				colorMultiplier = 1
			};

			e.ReplaceModeButtons(enabled, colorBlock);
		}

		private static void EndPreparations(GameEntity window) => window.Do((e) => e.isPrepared = true);
	}
}