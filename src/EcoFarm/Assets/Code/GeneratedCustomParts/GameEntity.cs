// ReSharper disable CheckNamespace - parts of classes suppose to de in same namespace as original class
public sealed partial class GameEntity
{
	public override string ToString() => hasDebugName ? $"{debugName.Value}_{creationIndex}" : base.ToString();
}