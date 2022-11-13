using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;

namespace Code.ECS.Features.Features
{
	public interface IGameServices : ISpawnPointsService, IConfigurationService, IUiService { }
}