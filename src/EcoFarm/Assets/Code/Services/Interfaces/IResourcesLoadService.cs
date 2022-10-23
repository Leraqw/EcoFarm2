using UnityEngine;

namespace Code.Services.Interfaces
{
	public interface IResourcesLoadService : IService
	{
		GameObject LoadGameObject(string path);
	}
}