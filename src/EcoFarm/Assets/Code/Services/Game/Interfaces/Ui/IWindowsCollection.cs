
using UnityEngine;

namespace Code
{
	public interface IWindowsCollection
	{
		WindowSell      Sell      { get; }
		GameObject      Pause     { get; }
		WindowBuild     Build     { get; }
		WindowResources Resources { get; }
	}
}