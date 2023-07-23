using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class ProgressBarValues
	{
		[field: SerializeField] public float Max     { get; set; }
		[field: SerializeField] public float Current { get; set; }
	}
}