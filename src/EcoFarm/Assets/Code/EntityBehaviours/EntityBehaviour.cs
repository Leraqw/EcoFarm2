using UnityEngine;

namespace Code.EntityBehaviours
{
	public class EntityBehaviour : MonoBehaviour
	{
		protected GameContext Context => Contexts.sharedInstance.game;
	}
}