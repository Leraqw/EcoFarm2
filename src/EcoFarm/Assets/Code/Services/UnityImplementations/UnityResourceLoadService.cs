using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityResourceLoadService : IResourcesLoadService
	{
		public GameObject LoadGameObject(string path) => Resources.Load<GameObject>(path);
	}
}