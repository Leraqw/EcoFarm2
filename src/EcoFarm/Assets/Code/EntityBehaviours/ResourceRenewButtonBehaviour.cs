using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.EntityBehaviours
{
	public class ResourceRenewButtonBehaviour : EntityBehaviour
	{
		[SerializeField] private TextView _textView;
		[SerializeField] private ProgressBarView _progressBarView;

		private bool _initialized;

		private void Update()
		{
			if (_initialized || _progressBarView.Entity == null)
			{
				return;
			}

			_progressBarView.Entity
			                .Do((e) => e.AddText(e.renewPrice))
			                // .Do((e) => e.AddView(gameObject))
			                .Do(_textView.Register)
				;
			_initialized = true;
		}
	}
}