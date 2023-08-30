using UnityEngine;

namespace EcoFarm
{
	public interface IDataProviderService
	{
		ModalWindow ModalWindow { get; }
		PlayersList PlayersList { get; }
		PlayerView PlayerView { get; }

		Storage Storage { get; }
	}
}