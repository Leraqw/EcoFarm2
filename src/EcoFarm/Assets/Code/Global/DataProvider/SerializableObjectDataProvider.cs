using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
    public class SerializableObjectDataProvider : IDataProviderService
    {
        public IEnumerable<Player> Players => Resources.Load<PlayersList>("StaticData/Players").Players;
        public PlayerView PlayerView => Resources.Load<PlayerView>("UI/Elements/Specified/Player");
        
        public Storage Storage => Resources.Load<Storage>("StaticData/Storage/Storage");
    }
}