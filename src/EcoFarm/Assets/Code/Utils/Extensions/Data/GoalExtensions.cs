namespace EcoFarm
{
	public static class GoalExtensions
	{
		public static GameEntity AddGoalTarget(this GameEntity entity, Goal goal)
		{
			if (goal is GoalByDevObject goalByDevelopmentObject)
			{
				entity.AddDevelopmentObject(goalByDevelopmentObject.DevObject);
			}

			return entity;
		}

		public static GameEntity MarkGoal(this GameEntity @this)
		{
			if (@this.goal.Value is GoalByDevObject { DevObject: Product product })
			{
				@this.AddProduct(product);
			}

			return @this;
		}
	}
}