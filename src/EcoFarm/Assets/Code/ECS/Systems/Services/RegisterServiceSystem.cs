using System;
using Code.Services.Interfaces;
using Entitas;

namespace Code.ECS.Systems.Services
{
	public sealed class RegisterServiceSystem<TService> : IInitializeSystem
	{
		private readonly TService _service;
		private readonly Action<TService> _register;

		public RegisterServiceSystem(TService service, Action<TService> register)
		{
			_service = service;
			_register = register;
		}

		public void Initialize() => _register.Invoke(_service);
	}
}