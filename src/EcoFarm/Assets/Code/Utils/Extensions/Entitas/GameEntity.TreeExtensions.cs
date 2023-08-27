using EcoFarm;
using Zenject;

public partial class GameEntity
{
	/// <summary> Use for inject only! </summary>
	[Inject] public IConfigurationService Configuration;

	public void ResetDroughtTimer() => AddDuration(Configuration.Balance.Watering.DroughtDuration);
}