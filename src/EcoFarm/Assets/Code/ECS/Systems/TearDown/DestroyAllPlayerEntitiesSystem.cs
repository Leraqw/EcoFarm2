using System.Linq;
using Entitas;

namespace EcoFarm
{
    public sealed class DestroyAllPlayerEntitiesSystem : ITearDownSystem
    {
        private readonly Contexts _contexts;

        public DestroyAllPlayerEntitiesSystem(Contexts contexts) => _contexts = contexts;

        public void TearDown()
            => _contexts.player.GetEntities()
                .Where(e => !e.isNotDestroy)
                .ForEach((e) => e.Destroy());
    }
}