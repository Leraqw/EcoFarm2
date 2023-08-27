using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
	public class ChangeModeSystem : ReactiveSystem<PlayerEntity>
	{
		private static IGroup<GameEntity> _modeButtons;

		public ChangeModeSystem(Contexts contexts)
			: base(contexts.player)
			=> _modeButtons = contexts.game.GetGroup(GameMatcher.ModeButtons);

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(PlayerMatcher.EditMode);

		protected override bool Filter(PlayerEntity entity) => entity.hasEditMode;

		protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ChangeMode);

		private static void ChangeMode(PlayerEntity entity)
		{
			var modeButtonEntity = _modeButtons;
			var enabled = new EnabledReceivers();

			SetMode(entity.editMode.Value, enabled, modeButtonEntity);
		}

		private static void SetMode(bool editMode, EnabledReceivers enabled, IGroup<GameEntity> modeButtonEntity)
		{
			enabled.PlayerToChoose = !editMode;
			enabled.PlayerToEdit = editMode;
			var selectedColor = CreateColorBlock(editMode ? Color.red : Color.white);
			modeButtonEntity.ForEach(e => e.ReplaceModeButtons(enabled, selectedColor));
		}

		private static ColorBlock CreateColorBlock(Color selectedColor)
		{
			return new ColorBlock
			{
				normalColor = Color.white, highlightedColor = Color.white, pressedColor = Color.white,
				selectedColor = selectedColor,
				colorMultiplier = 1
			};
		}
	}
}