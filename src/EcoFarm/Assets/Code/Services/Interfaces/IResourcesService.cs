using UnityEngine;

namespace EcoFarm
{
	public interface IResourcesService : IService
	{
		GameObject LoadGameObject(string path);
		Sprite LoadSprite(string path);
	}
}