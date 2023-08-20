using EcoFarm;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
	public class ProjectInstaller : MonoInstaller<ProjectInstaller>
	{
		[SerializeField] private GlobalEntitasAdapter _globalEntitasAdapter;

		public override void InstallBindings()
		{
			BindAdapter();
		}

		private void BindAdapter()
			=> Container.Bind<GlobalEntitasAdapter>()
			            .FromNewComponentOnNewPrefab(_globalEntitasAdapter)
			            .AsSingle()
			            .NonLazy();
	}
}