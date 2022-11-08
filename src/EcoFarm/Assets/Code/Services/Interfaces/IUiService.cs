using Code.Unity.Containers;
using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IUiService
	{
		GameObject         CoinsView  { get; }
		GameObject         AppleView  { get; }
		ClosableWindow     SellWindow { get; }
	}
}