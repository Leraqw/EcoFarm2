using EcoFarmDataModule;

namespace Code.Utils.Extensions.Data
{
	public static class GoalExtensions
	{
		public static GameEntity AddGoalTarget(this GameEntity entity, Goal goal)
		{
			if (goal is GoalByDevelopmentObject goalByDevelopmentObject)
			{
				entity.AddDevelopmentObject(goalByDevelopmentObject.DevelopmentObject);
			}

			return entity;
		}
	}
}