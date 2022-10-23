using Code.Services.Interfaces;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Services] [Unique] public sealed class ResourcesLoadService : ValueComponent<IResourcesLoadService> { }
}