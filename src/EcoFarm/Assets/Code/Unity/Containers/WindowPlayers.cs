using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class WindowPlayers : MonoBehaviour
    {
        [field: SerializeField] public TextMeshProUGUI PlayerName { get; private set; }
    }
}