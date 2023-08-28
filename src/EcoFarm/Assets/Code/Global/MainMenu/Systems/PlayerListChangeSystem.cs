using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Zenject;
using static PlayerMatcher;


namespace EcoFarm
{
    public class PlayerListChangedSystem : IInitializeSystem, IExecuteSystem
    {
        private readonly IDataProviderService _dataProvider;
        private  PlayerEntity _entity;
        private readonly Contexts _contexts;
        private readonly PlayerEntity.Factory _playerEntityFactory;

        [Inject]
        public PlayerListChangedSystem
        (
            Contexts contexts,
            IDataProviderService dataProvider,
            PlayerEntity.Factory playerEntityFactory
        )
        {
            _contexts = contexts;
            _playerEntityFactory = playerEntityFactory;
            _dataProvider = dataProvider;
        }

        private List<Player> Players => _dataProvider.PlayersList.Players;

        public void Initialize()
        {
            _playerEntityFactory.Create().AddPlayerListLength(Players.Count);
            _entity = _contexts.player.playerListLengthEntity;
        }

        public void Execute() => _entity.ReplacePlayerListLength(Players.Count);
    }
}