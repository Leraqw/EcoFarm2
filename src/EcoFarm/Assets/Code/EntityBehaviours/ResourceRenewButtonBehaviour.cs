using System.Collections;
using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.EntityBehaviours
{
	public class ResourceRenewButtonBehaviour : EntityBehaviour
	{
		[SerializeField] private TextView _textView;
		[SerializeField] private ProgressBarView _progressBarView;

		private void Start() => StartCoroutine(InitializationLoop());

		private IEnumerator InitializationLoop()
		{
			while (true)
			{
				if (_progressBarView.Entity == null)
				{
					yield return null;
				}

				_progressBarView.Entity
				                .Do((e) => e.AddText(e.renewPrice))
				                // .Do((e) => e.AddView(gameObject))
				                .Do(_textView.Register)
					;
				yield break;
			}
		}
	}
}