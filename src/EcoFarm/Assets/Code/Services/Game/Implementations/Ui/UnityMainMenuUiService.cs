using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class UnityMainMenuUiService : IMainMenuUiService
    {
        [SerializeField] private WindowsCollection _windows;

        public IWindowsCollection Windows => _windows;
        [field: SerializeField] public PlayerChoiceView PlayerChoiceView { get; private set; }
    }
}