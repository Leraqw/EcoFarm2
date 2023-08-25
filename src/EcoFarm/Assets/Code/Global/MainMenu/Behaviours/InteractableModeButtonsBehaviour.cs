using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class InteractableModeButtonsBehaviour : MonoBehaviour, IPlayerToEditListener
    {
        [SerializeField] private List<InteractableView> _interactableView;

        private void Start()
        {
            var entity = Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First();
            entity.AddPlayerToEditListener(this);
           // entity.AddInteractable(false);
            _interactableView.ForEach(e => e.Register(entity));
        }

        public void OnPlayerToEdit(PlayerEntity entity, PlayerView value) 
            => entity.ReplaceInteractable(true);
    }
}