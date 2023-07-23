using EcoFarmModel;

namespace Code
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

		public static GameEntity MarkGoal(this GameEntity @this)
		{
			if (@this.goal.Value is GoalByDevelopmentObject { DevelopmentObject: Product product })
			{
				@this.AddProduct(product);
			}

			return @this;
		}
	}
}