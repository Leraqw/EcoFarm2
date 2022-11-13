using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Code.Menus.UiBehaviours.MainMenu
{
	public class ButtonPlay : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() => _button.onClick.AddListener(ToGameplayScene);

		private void OnDisable() => _button.onClick.RemoveListener(ToGameplayScene);

		private void ToGameplayScene() => SceneManager.LoadScene("GameplayScene");
	}
}