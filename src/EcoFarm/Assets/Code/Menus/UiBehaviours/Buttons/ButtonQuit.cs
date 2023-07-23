using UnityEngine;

namespace Code
{
	public class ButtonQuit : UnityEventAdapter
	{
		protected override void OnButtonClick()
		{
			Application.Quit();
		}
	}
}