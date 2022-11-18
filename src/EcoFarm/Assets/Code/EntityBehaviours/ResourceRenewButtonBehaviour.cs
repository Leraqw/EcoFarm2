using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.EntityBehaviours
{
	public class ResourceRenewButtonBehaviour : EntityBehaviour
	{
		[SerializeField] private TextView _textView;

		private void Start()
		{
			Context.CreateEntity()
			       .Do((e) => e.AddDebugName("Behaviour — Resource Renew Button"))
			       .Do((e) => e.AddText("XX"))
			       .Do((e) => e.AddView(gameObject))
			       .Do(_textView.Register)
				;
		}
	}
}