using Code.Utils.Extensions;

namespace Code.EntityBehaviours
{
	public class ResourceRenewButton : EntityBehaviour
	{
		private void Start()
		{
			Context.CreateEntity()
			       .Do((e) => e.AddDebugName("Behaviour — Resource Renew Button"))
			       .Do((e) => e.AddView(gameObject))
			       .Do((e) => e.AddText("XX"))
				;
		}
	}
}