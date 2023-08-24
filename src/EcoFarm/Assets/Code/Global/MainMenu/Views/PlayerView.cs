using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class PlayerView : BaseViewListener, IPlayerToChooseListener
    {
        [SerializeField] private TextMeshProUGUI _level;
        [SerializeField] private TextMeshProUGUI _nickname;
        [field: SerializeField] public Player Player { get; private set; }
        [field: SerializeField] public ModeButtons ModeButtons { get; private set; }

        protected override void AddListener(GameEntity entity) => entity.AddPlayerToChooseListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasPlayerToChoose;

        protected override void UpdateValue(GameEntity entity) => OnPlayerToChoose(entity, entity.playerToChoose.Value);

        public void OnPlayerToChoose(GameEntity entity, Player value)
        {
            _level.text = value.CompletedLevelsCount.ToString();
            _nickname.text = value.Nickname;
            Player = value;
        }
    }
}