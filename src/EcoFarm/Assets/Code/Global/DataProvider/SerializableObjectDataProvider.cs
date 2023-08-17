using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
    public class SerializableObjectDataProvider : IDataProviderService
    {
        public IEnumerable<Player> Players => Resources.Load<PlayersList>("StaticData/Players").Players;

        public Storage Storage => Resources.Load<Storage>("StaticData/Storage/Storage");
    }

    public class PrefabDataProvider : MonoBehaviour, IPrefabDataProvider
    {
        [SerializeField] private EnabledView _enabledView;
        [SerializeField] private GameObject _playerChoicePrefab;
        public GameObject PlayerChoiceView => _playerChoicePrefab;
        public EnabledView EnabledView => _enabledView;
    }

    public interface IPrefabDataProvider
    {
        GameObject PlayerChoiceView { get; }
        EnabledView EnabledView { get; }
    }
}