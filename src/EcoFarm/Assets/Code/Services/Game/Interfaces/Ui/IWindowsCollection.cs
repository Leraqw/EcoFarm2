
using UnityEngine;

namespace EcoFarm
{
	public interface IWindowsCollection
	{
		WindowSell      Sell      { get; }
		GameObject      Pause     { get; }
		WindowBuild     Build     { get; }
		WindowResources Resources { get; }
		WindowPlayers Players { get; }
	}
}