using UnityEngine;

namespace Code.Unity
{
	public class SceneConfig : MonoBehaviour
	{
		[SerializeField] private Transform _debugTreeSpawnPosition;
		
		public Transform DebugTreeSpawnPosition => _debugTreeSpawnPosition;
	}
}