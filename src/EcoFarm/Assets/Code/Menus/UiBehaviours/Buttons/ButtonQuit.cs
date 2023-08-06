using UnityEngine;

namespace EcoFarm
{
	public class ButtonQuit : UnityEventAdapter
	{
		protected override void OnButtonClick()
		{
			Application.Quit();
		}
	}
}