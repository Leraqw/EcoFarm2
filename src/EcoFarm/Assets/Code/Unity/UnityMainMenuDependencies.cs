using UnityEngine;

namespace EcoFarm
{
    public class UnityMainMenuDependencies : MonoBehaviour
    {
        [field: SerializeField] public UnityMainMenuUiService UiService { get; private set; }
    }
}