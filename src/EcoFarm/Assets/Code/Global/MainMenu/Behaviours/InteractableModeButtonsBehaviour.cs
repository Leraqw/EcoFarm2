using System.Collections.Generic;
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
            var entities = Contexts.sharedInstance.player.GetEntities(EditMode);
            
            foreach (var entity in entities)
            {
                entity.AddPlayerToEditListener(this);
                _interactableView.ForEach(e => e.Register(entity));
            }
        }

        public void OnPlayerToEdit(PlayerEntity entity, PlayerView value)
            => entity.ReplaceInteractable(true);
    }
}