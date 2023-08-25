using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ModeButtonsBehaviour : MonoBehaviour, IEditModeListener
    {
        [field: SerializeField] public List<GameObject> EditModeButtons { get; private set; }
        [field: SerializeField] public List<GameObject> ChooseModeButtons { get; private set; }

        private void Start() =>
            Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First()
                .AddEditModeListener(this);

        public void OnEditMode(PlayerEntity entity, bool value)
        {
            EditModeButtons.ForEach(e => e.SetActive(value));
            ChooseModeButtons.ForEach(e => e.SetActive(!value));
        }
    }
}