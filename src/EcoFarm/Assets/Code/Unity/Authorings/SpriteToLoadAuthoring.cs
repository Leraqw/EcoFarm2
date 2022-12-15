using UnityEngine;

namespace Code
{
	public class SpriteToLoadAuthoring : RegistrarBase
	{
		[SerializeField] private Sprite _value;

		public override void Register(ref GameEntity entity) => entity.AddSpriteToLoad(_value);
	}
}