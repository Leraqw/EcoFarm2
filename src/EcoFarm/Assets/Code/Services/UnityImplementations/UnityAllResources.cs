using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllResources : IAllServices
	{
		private readonly IResourcesLoadService _resourceLoader;

		public UnityAllResources() => _resourceLoader = new UnityResourceLoadService();

		GameObject IResourcesLoadService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);
	}
}