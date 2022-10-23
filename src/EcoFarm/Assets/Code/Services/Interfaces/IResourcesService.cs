using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IResourcesService : IService
	{
		GameObject LoadGameObject(string path);
	}
}