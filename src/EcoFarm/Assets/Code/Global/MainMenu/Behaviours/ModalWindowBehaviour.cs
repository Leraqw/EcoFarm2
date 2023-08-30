using System;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public class ModalWindowBehaviour : MonoBehaviour, IModalWindowDataListener
    {
        private GameEntity.Factory _gameEntityFactory;
        private GameContext _context;
        private IDataProviderService _dataProvider;
        private Injector _injector;

        [Inject]
        public void Construct(GameEntity.Factory gameEntityFactory,
            GameContext context,
            IDataProviderService dataProvider,
            Injector injector)
        {
            _context = context;
            _gameEntityFactory = gameEntityFactory;
            _dataProvider = dataProvider;
            _injector = injector;
        }

        private void Start()
        {
            var e = _gameEntityFactory.Create();
            e.isModalWindow = true;
            e.AddDebugName("modal_window");
            e.AddModalWindowDataListener(this);
        }

        public void OnModalWindowData(GameEntity entity, string title, string message)
        {
            _dataProvider.ModalWindow.Title.text = title;
            _dataProvider.ModalWindow.Message.text = message;
         
            var viewPrefab = Instantiate(_dataProvider.ModalWindow, gameObject.transform, false);
            _injector.InjectGameObject(viewPrefab.gameObject);
        }
    }
}