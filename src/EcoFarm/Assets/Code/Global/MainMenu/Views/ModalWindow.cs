using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace EcoFarm
{
    public class ModalWindow : MonoBehaviour
    {
        [field: SerializeField] public TextMeshProUGUI Title { get; private set; }
        [field: SerializeField] public TextMeshProUGUI Message { get; private set; }
    }
}