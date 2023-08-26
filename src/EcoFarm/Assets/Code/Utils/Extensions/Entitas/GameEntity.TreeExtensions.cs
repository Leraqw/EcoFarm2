using EcoFarm;
using Zenject;

public partial class GameEntity
{
	// ideally Zenject shouldn't reach here
	// but you can mark fields with the [Inject] attribute just to make it clear that it's a container dependency.
	[Inject] private IConfigurationService _configuration; 

	public void ResetDroughtTimer() => AddDuration(_configuration.Balance.Watering.DroughtDuration);
}