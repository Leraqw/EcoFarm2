using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace EcoFarm
{
	public abstract class BaseButtonClickReceiver : MonoBehaviour
	{
		[field: SerializeField] public Button Button { get; private set; }

		protected GameContext Context => Contexts.sharedInstance.game;

		private void OnEnable() => Button.onClick.AddListener(OnButtonClick);

		private void OnDisable() => Button.onClick.RemoveListener(OnButtonClick);

		protected abstract void OnButtonClick();
	}
}