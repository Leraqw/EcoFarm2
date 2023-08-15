using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class WindowsCollection : IWindowsCollection
    {
        [field: SerializeField] public WindowSell Sell { get; private set; }
        [field: SerializeField] public GameObject Pause { get; private set; }
        [field: SerializeField] public WindowScroll Build { get; private set; }
        [field: SerializeField] public WindowResources Resources { get; private set; }
        [field: SerializeField] public WindowPlayers Players { get; private set; }
    }
}