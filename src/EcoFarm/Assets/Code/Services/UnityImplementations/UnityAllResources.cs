using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityAllResources : IAllServices
	{
		private readonly IResourcesService _resourceLoader;

		public UnityAllResources() => _resourceLoader = new UnityResourceService();

		GameObject IResourcesService.LoadGameObject(string path) => _resourceLoader.LoadGameObject(path);
	}
}