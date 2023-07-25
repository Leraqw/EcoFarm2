using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Code
{
	[Services] [Unique] public sealed class DataProviderComponent : IComponent { public IDataProviderService Value; }
}