using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ModeButtonsReceiver : MonoBehaviour, IEditModeListener
    {
        [SerializeField] private List<GameObject> _editModeButtons;
        [SerializeField] private List<GameObject> _chooseModeButtons;

        private void Start()
        {
            var e = Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First();

            e.AddEditModeListener(this);
        }

        public void OnEditMode(PlayerEntity entity, bool value)
        {
            _editModeButtons.ForEach(e => e.SetActive(value));
            _chooseModeButtons.ForEach(e => e.SetActive(!value));
        }
    }
}