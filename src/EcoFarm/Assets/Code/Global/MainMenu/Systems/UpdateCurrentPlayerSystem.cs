using System.Collections.Generic;
using System.Linq;
using Entitas;
using Zenject;

namespace EcoFarm
{
    public class UpdateCurrentPlayerSystem : IInitializeSystem, IExecuteSystem
    {
        private readonly PlayerContext _context;
        private readonly IDataProviderService _dataProvider;
        private PlayerEntity _entity;

        [Inject]
        public UpdateCurrentPlayerSystem(PlayerContext context, IDataProviderService dataProvider)
        {
            _context = context;
            _dataProvider = dataProvider;
        }

        private IEnumerable<Player> Players => _dataProvider.PlayersList.Players;

        public void Initialize() => _entity = _context.currentPlayerEntity;

        public void Execute()
        {
            if (!Players.Any())
            {
                if (_entity.hasNickname) _entity.RemoveNickname();

                _entity.ReplaceCompletedLevelsCount(0);
                return;
            }

            _entity.ReplaceNickname(Players.First().Nickname);
            _entity.ReplaceCompletedLevelsCount(Players.First().CompletedLevelsCount);
        }
    }
}