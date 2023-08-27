using TMPro;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ButtonSaveNewPlayerReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private TMP_InputField _inputField;

		private IDataProviderService _dataProvider;

		[Inject]
		public void Construct(IDataProviderService dataProvider) 
			=> _dataProvider = dataProvider;

		private PlayersList PlayersList => _dataProvider.PlayersList;

		protected override void OnButtonClick() => PlayersList.AddPlayer(_inputField.text);
	}
}