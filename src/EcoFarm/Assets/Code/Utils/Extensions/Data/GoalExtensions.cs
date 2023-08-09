namespace EcoFarm
{
	public static class GoalExtensions
	{
		public static GameEntity AddGoalTarget(this GameEntity entity, GoalSO goal)
		{
			if (goal is GoalByDevObjectSO goalByDevelopmentObject)
			{
				entity.AddDevelopmentObject(goalByDevelopmentObject.DevObject);
			}

			return entity;
		}

		public static GameEntity MarkGoal(this GameEntity @this)
		{
			if (@this.goal.Value is GoalByDevObjectSO { DevObject: ProductSO product })
			{
				@this.AddProduct(product);
			}

			return @this;
		}
	}
}