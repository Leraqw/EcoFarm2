using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.Game.Interfaces.Ui
{
	public interface IWindowsCollection
	{
		WindowSell  Sell  { get; }
		GameObject  Pause { get; }
		WindowBuild Build { get; }
	}
}