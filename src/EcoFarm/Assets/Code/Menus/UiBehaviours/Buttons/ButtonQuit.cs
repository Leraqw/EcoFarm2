using UnityEngine;

namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonQuit : UnityEventAdapter
	{
		protected override void OnButtonClick()
		{
			Application.Quit();
		}
	}
}