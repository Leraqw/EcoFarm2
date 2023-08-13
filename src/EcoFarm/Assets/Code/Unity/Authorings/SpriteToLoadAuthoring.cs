using UnityEngine;

namespace EcoFarm
{
	public class SpriteToLoadAuthoring : AuthoringBase
	{
		[SerializeField] private Sprite _value;

		public override void Register(ref GameEntity entity) => entity.AddSpriteToLoad(_value);
	}
}