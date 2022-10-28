using UnityEngine;

namespace Code.Unity.ViewListeners
{
	public class ProportionalScaleView : MonoBehaviour, IProportionalScaleListener
	{
		public void Register(GameEntity entity) => entity.AddProportionalScaleListener(this);

		public void OnProportionalScale(GameEntity entity, float value) => transform.localScale = Vector3.one * value;
	}
}