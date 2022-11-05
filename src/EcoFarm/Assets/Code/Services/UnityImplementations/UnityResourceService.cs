using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	public class UnityResourceService : IResourcesService
	{
		public GameObject LoadGameObject(string path) => Resources.Load<GameObject>(path);
		
		public Sprite LoadSprite(string path) => Resources.Load<Sprite>(path);
	}
}