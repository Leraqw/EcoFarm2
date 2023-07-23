using UnityEngine;

namespace Code
{
	public interface IResourcesService : IService
	{
		GameObject LoadGameObject(string path);
		Sprite LoadSprite(string path);
	}
}