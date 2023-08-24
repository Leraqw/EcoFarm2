namespace EcoFarm
{
	public sealed class UiSystems : FeatureBase
	{
		public UiSystems(SystemsFactory factory)
			: base(nameof(UiSystems), factory)
		{
			Add<InitializeSellWindowSystem>();
			Add<InitializeBuildWindowSystem>();
			Add<InitializePauseWindowSystem>();
			Add<InitializeCountToSellSliderSystem>();
			Add<InitializeCurrentCountTextSystem>();
			Add<InitializeCoinsReceiveCountTextSystem>();

			Add<OnToggleActivityButtonClickSystem>();
			Add<OnSliderValueChangedSystem>();
			Add<PrepareSellWindowSystem>();
			Add<PrepareBuildWindowSystem>();
			Add<EnablePreparedWindow>();
		}
	}
}