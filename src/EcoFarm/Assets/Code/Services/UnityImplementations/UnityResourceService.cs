using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityResourceService : IResourcesService
	{
		public GameObject LoadGameObject(string path) => Resources.Load<GameObject>(path);
	}
}