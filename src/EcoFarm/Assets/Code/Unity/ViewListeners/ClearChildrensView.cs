using Code.Utils.Extensions;

namespace Code.Unity.ViewListeners
{
	public class ClearChildrensView : BaseViewListener, IClearChildrensListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddClearChildrensListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.isClearChildrens;

		protected override void UpdateValue(GameEntity entity) => OnClearChildrens(entity);

		public void OnClearChildrens(GameEntity entity) => transform.DestroyChildrens();
	}
}