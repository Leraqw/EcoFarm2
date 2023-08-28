using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using UnityEngine.UI;
using static GameMatcher;
using static PlayerMatcher;

namespace EcoFarm
{
    public sealed class InitializePlayerChoiceWindowSystem : ReactiveSystem<GameEntity>
    {
        private readonly IDataProviderService _dataProvider;
        private readonly GameEntity.Factory _gameEntityFactory;
        private readonly PlayerEntity.Factory _playerEntityFactory;
        private readonly Injector _injector;
        private readonly PlayerContext _context;

        public InitializePlayerChoiceWindowSystem
        (
            Contexts contexts,
            IDataProviderService dataProvider,
            GameEntity.Factory gameEntityFactory,
            PlayerEntity.Factory playerEntityFactory,
            Injector injector,
            PlayerContext context
        )
            : base(contexts.game)
        {
            _playerEntityFactory = playerEntityFactory;
            _dataProvider = dataProvider;
            _gameEntityFactory = gameEntityFactory;
            _injector = injector;
            _context = context;
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

        private void CleanPlayerList(GameEntity window)
        {
            window.GetAttachedEntities()
                .Do((entities) => entities.ForEach((e) => e.isDestroy = true))
                .Do((entities) => entities.ForEach((e) => e.viewPrefab.Value.DestroyGameObject()));

            _context.GetEntities(PlayerModeButtonsEnabled).ForEach(e => e.isDestroy = true);
        }

        private void FillPlayerList(GameEntity window)
            => Players.ForEach((player) => BindPlayerChoiceView(player, PlayerViewPrefab, window));

        private void BindPlayerChoiceView(Player player, PlayerView prefab, GameEntity window)
        {
            var e = _gameEntityFactory.Create();
            var viewPrefab = Object.Instantiate(prefab, window.playerWindowContent.Value);
            _injector.InjectGameObject(viewPrefab.gameObject);

            e.AddPlayerToChoose(player);
            viewPrefab.Register(e);
            e.AttachTo(window);
            e.AddDebugName($"playerItem_{player.Nickname}");
            e.AddViewPrefab(viewPrefab.gameObject);

            var playerEntity = _playerEntityFactory.Create();
            playerEntity.AddPlayerModeButtonsEnabled(false);
            viewPrefab.PlayerModeButtons.Register(playerEntity);
        }

        private static void EndPreparations(GameEntity window) => window.Do((e) => e.isPrepared = true);
    }
}