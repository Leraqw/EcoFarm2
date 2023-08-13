using System.Collections;
using UnityEngine;

namespace EcoFarm
{
	public abstract class StartEntityBehaviour : MonoBehaviour
	{
		protected static Contexts Contexts => Contexts.sharedInstance;

		protected virtual bool IsReadyForInitialization => true;

		private void Start() => StartCoroutine(InitializationLoop());

		private IEnumerator InitializationLoop()
		{
			if (!IsReadyForInitialization)
				yield return new WaitUntil(() => IsReadyForInitialization);

			Initialize();
		}

		protected abstract void Initialize();
	}
}