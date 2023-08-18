using System.Collections.Generic;
using System.Linq;
using Entitas;
using Entitas.Unity;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class PreparePlayerChoiceWindowSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _context;

        public PreparePlayerChoiceWindowSystem(Contexts contexts) : base(contexts.game) => _context = contexts;
        private static IEnumerable<Player> Players => ServicesMediator.DataProvider.Players;

        private static PlayerView PlayerViewPrefab => ServicesMediator.DataProvider.PlayerView;
        
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
            var e = _context.game.CreateEntity();

            e.AddPlayerToChoose(player);
            prefab.Register(e);
            e.AttachTo(window);
            e.AddDebugName($"playerItem_{player.Nickname}");

            var viewPrefab = Object.Instantiate(prefab.gameObject, window.playerWindowContent.Value);
            e.AddViewPrefab(viewPrefab);
        }

        private static void EndPreparations(GameEntity window)
            => window.Do((e) => e.isPrepared = true);
    }
}