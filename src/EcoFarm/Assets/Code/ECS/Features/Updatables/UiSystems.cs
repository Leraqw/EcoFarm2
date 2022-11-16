using Code.ECS.Systems.UI;
using Code.ECS.Systems.UI.Initialization;

namespace Code.ECS.Features.Updatables
{
	public sealed class UiSystems : Feature
	{
		public UiSystems(Contexts contexts)
			: base(nameof(UiSystems))
		{
			Add(new InitializeSellWindowSystem(contexts));
			Add(new InitializeBuildWindowSystem(contexts));
			Add(new InitializePauseWindowSystem(contexts));
			Add(new InitializeCountToSellSliderSystem(contexts));
			Add(new InitializeCurrentCountTextSystem(contexts));
			
			Add(new OnToggleActivityButtonClickSystem(contexts));
			Add(new OnSliderValueChangedSystem(contexts));
			Add(new PrepareSellWindowSystem(contexts));
			Add(new EnablePreparedWindow(contexts));
		}
	}
}