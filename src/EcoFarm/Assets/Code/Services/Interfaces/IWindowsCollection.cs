using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IWindowsCollection
	{
		WindowSell Sell  { get; }
		GameObject Pause { get; }
	}
}