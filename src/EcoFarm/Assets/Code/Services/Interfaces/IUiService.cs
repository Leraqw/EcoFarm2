using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IUiService
	{
		GameObject         CoinsView  { get; }
		GameObject         AppleView  { get; }
		GameObject         SellWindow { get; }
		IButtonsCollection Buttons    { get; }
	}
}