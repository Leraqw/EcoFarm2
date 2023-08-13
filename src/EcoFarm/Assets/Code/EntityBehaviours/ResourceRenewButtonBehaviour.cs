using UnityEngine;

namespace EcoFarm
{
	public class ResourceRenewButtonBehaviour : StartEntityBehaviour
	{
		[SerializeField] private ProgressBarView _progressBarView;

		protected override bool IsReadyForInitialization => ProgressBarEntity != null;

		private GameEntity ProgressBarEntity => _progressBarView.Entity;

		protected override void Initialize()
			=> ProgressBarEntity.AddText(ProgressBarEntity.renewPrice.Value.ToString());
	}
}