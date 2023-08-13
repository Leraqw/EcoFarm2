﻿
using UnityEngine;

namespace EcoFarm
{
	public class LevelChoiceToEntitasAdapter : MonoBehaviour
	{
		private LevelChoiceSystems _systems;
		
		private void Start()
		{
			_systems = new LevelChoiceSystems();
			_systems.Initialize();			
		}

		private void Update()
		{
			_systems.Execute();
			_systems.Cleanup();
		}

		private void OnDestroy()
		{
			_systems.TearDown();
		}
	}
}