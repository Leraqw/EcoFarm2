using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	// ReSharper disable once InconsistentNaming – it's temporary name
	public abstract class EnvironmentParameterTypeSO
	{
		[field: SerializeField] public string Title       { get; private set; }
		[field: SerializeField] public string Description { get; private set; }
	}
}