using System.Linq;
using Entitas;

namespace EcoFarm
{
	public static class ProductsExtensions
	{
		public static GameEntity FirstProductFor(this IGroup<GameEntity> @this, GameEntity request)
			=> @this.GetEntities()
			        .First((e) => e.product.Value == request.requireProduct.Value);
	}
}