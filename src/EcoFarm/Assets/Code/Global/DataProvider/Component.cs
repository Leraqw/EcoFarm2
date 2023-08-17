using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace EcoFarm
{
	[Services] [Unique] public sealed class DataProviderComponent : IComponent { public IDataProviderService Value; }
}