using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class PlayerChoiceView: BaseViewListener, IPlayerToChooseListener
    {
        [SerializeField] private TextMeshProUGUI _nickName;

        protected override void AddListener(GameEntity entity) => entity.AddPlayerToChooseListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasPlayerToChoose;

        protected override void UpdateValue(GameEntity entity) => OnPlayerToChoose(entity, entity.playerToChoose.Value);
        
        public void OnPlayerToChoose(GameEntity entity, Player value) => _nickName.text = value.Nickname;
    }
}