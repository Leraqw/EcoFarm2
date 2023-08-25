using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class ButtonSaveNewPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private TMP_InputField _inputField;
        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;

        protected override void OnButtonClick() => PlayersList.AddPlayer(_inputField.text);
    }
}