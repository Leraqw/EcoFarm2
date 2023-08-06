﻿using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class CommonConfig : ICommonConfig
	{
		[field: SerializeField] public float Tolerance { get; private set; } = 0.01f;
	}
}