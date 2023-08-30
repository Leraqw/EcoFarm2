using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class PlayerModeButtons : IPlayerModeButtonsEnabledListener
    {
        [field: SerializeField] public BaseButtonClickReceiver PlayerToChooseReceiver { get; private set; }
        [field: SerializeField] public BaseButtonClickReceiver PlayerToEditReceiver { get; private set; }
        [SerializeField] private Color _editModeSelectedButtonColor;

        public void Register(PlayerEntity entity)
        {
            entity.AddPlayerModeButtonsEnabledListener(this);

            if (entity.hasEditMode)
                OnPlayerModeButtonsEnabled(entity, entity.editMode.Value);
        }

        public void OnPlayerModeButtonsEnabled(PlayerEntity entity, bool value)
        {
            SetButtonReceiverData(PlayerToChooseReceiver, !value);
            SetButtonReceiverData(PlayerToEditReceiver, value);
        }

        private void SetButtonReceiverData(BaseButtonClickReceiver receiver, bool enabled)
        {
            receiver.enabled = enabled;

            var colors = receiver.Button.colors;
            var selectedColor = enabled ? _editModeSelectedButtonColor : colors.selectedColor;

            colors.selectedColor = selectedColor;
            receiver.Button.colors = colors;
        }
    }
}