
namespace Code.Unity.ViewListeners
{
	public class EnabledView : BaseViewListener, IEnabledListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddEnabledListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasEnabled;

		protected override void UpdateValue(GameEntity entity) => OnEnabled(entity, entity.isEnabled);

		public void OnEnabled(GameEntity entity, bool value) => gameObject.SetActive(value);
	}
}