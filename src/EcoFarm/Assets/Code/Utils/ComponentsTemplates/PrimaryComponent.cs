using Entitas;
using Entitas.CodeGeneration.Attributes;
// ReSharper disable All

namespace Packages.Code.Ecs.Components.Workflow
{
	public class PrimaryComponent<T> : IComponent
	{
		[PrimaryEntityIndex] public T Value;

		public static implicit operator T(PrimaryComponent<T> component)
			=> component.Value;

		public static implicit operator string(PrimaryComponent<T> component)
			=> component.Value.ToString();
	}
}
