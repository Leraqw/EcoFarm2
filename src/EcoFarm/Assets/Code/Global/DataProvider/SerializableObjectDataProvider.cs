using UnityEngine;

namespace EcoFarm
{
    public class SerializableObjectDataProvider : IDataProviderService
    {
        public PlayersList PlayersList => Resources.Load<PlayersList>("StaticData/Players");

        public PlayerView PlayerView => Resources.Load<PlayerView>("UI/Elements/Specified/Player");

        public Storage Storage => Resources.Load<Storage>("StaticData/Storage/Storage");
    }
}