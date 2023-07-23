using System;
using Entitas;

namespace Code
{
	public sealed class RegisterServiceSystem<TService> : IInitializeSystem
	{
		private readonly TService _service;
		private readonly Action<TService> _register;

		public RegisterServiceSystem(TService service, Action<TService> register)
			=> (_service, _register) = (service, register);

		public void Initialize() => _register.Invoke(_service);
	}
}