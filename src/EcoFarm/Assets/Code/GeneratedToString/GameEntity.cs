// ReSharper disable once CheckNamespace - namespace частей parital классов должен сопадать
public sealed partial class GameEntity
{
	public override string ToString() => hasTreeSprite ? "Tree" : base.ToString();
}