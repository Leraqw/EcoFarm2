
using UnityEngine;

namespace EcoFarm
{
	public interface IWindowsCollection
	{
		WindowSell      Sell      { get; }
		GameObject      Pause     { get; }
		WindowScroll     Build     { get; }
		WindowResources Resources { get; }
	}
}