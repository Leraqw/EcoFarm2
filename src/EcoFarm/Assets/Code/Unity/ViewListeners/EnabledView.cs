
namespace Code.Unity.ViewListeners
{
	public class EnabledView : BaseViewListener, IEnabledListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddEnabledListener(this);

		protected override bool HasComponent(GameEntity entity) => true;

		protected override void UpdateValue(GameEntity entity) => OnEnabled(entity);

		public void OnEnabled(GameEntity entity) => enabled = entity.isEnabled;
	}
}