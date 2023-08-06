
namespace EcoFarm
{
	public class EnabledView : BaseViewListener, IActivateListener
	{
		protected override void AddListener(GameEntity entity) => entity.AddActivateListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasActivate;

		protected override void UpdateValue(GameEntity entity) => OnActivate(entity, entity.isEnabled);

		public void OnActivate(GameEntity entity, bool value) => gameObject.SetActive(value);
	}
}