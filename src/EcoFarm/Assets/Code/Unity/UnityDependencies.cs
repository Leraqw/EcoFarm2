using Code.Services.Interfaces;
using Code.Services.UnityImplementations;
using UnityEngine;

namespace Code.Unity
{
	public class UnityDependencies : MonoBehaviour
	{
		[SerializeField] private UnitySceneObjectsService _sceneObjects;

		public ISceneObjectsService SceneObjects => _sceneObjects;
	}
}