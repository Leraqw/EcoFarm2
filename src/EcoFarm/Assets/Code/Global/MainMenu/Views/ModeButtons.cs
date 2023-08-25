using Entitas;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
    public class ModeButtons : BaseViewListener, IModeButtonsListener
    {
        [field: SerializeField] public BaseButtonClickReceiver PlayerToChooseReceiver { get; set; }
        [field: SerializeField] public BaseButtonClickReceiver PlayerToEditReceiver { get; set; }

        private void Start()
        {
            Contexts.sharedInstance.game
                .GetEntities(GameMatcher.ModeButtons)
                .ForEach(e => e.AddModeButtonsListener(this));
        }

        public void OnModeButtons(GameEntity entity, EnabledReceivers enabled, ColorBlock value)
        {
            Debug.Log($"PlayerToEdit: {enabled.PlayerToEdit}");
            Debug.Log($"PlayerToChoose: {enabled.PlayerToChoose}");
            PlayerToChooseReceiver.enabled = enabled.PlayerToChoose;
            PlayerToEditReceiver.enabled = enabled.PlayerToEdit;

            PlayerToChooseReceiver.Button.colors = value;
            PlayerToEditReceiver.Button.colors = value;
        }

        protected override void AddListener(GameEntity entity) => entity.AddModeButtonsListener(this);

        protected override bool HasComponent(GameEntity entity) => entity.hasModeButtons;

        protected override void UpdateValue(GameEntity entity) =>
            OnModeButtons(entity, entity.modeButtons.Enabled, entity.modeButtons.Color);
    }

    public struct EnabledReceivers
    {
        public bool PlayerToChoose;
        public bool PlayerToEdit;
    }
}