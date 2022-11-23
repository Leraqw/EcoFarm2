using System.Collections.Generic;
using System.Linq;
using Code.Menus.LevelSelectorScreen;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.Global.LevelChoice.Unity
{
	public class UnlockedLevelsCountView : MonoBehaviour, IUnlockedLevelsCountListener
	{
		[SerializeField] private List<LevelButton> _levels;
		
		public PlayerEntity Entity { get; private set; }
		
		public void Register(PlayerEntity entity)
		{
			Entity = entity;
			Entity.AddUnlockedLevelsCountListener(this);
			
			if (Entity.hasUnlockedLevelsCount)
			{
				OnUnlockedLevelsCount(Entity, Entity.unlockedLevelsCount);
			}
		}

		public void OnUnlockedLevelsCount(PlayerEntity entity, int value)
		{
			_levels.Take(value).ForEach((b) => b.IsCompleted = true);
			_levels.Skip(value).ForEach((b) => b.IsCompleted = false);
			
			_levels.Take(value + 1).ForEach((b) => b.SetButtonEnabled(true));
			_levels.Skip(value + 1).ForEach((b) => b.SetButtonEnabled(false));
		}
	}
}