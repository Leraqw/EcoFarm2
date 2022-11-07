﻿using System;
using Code.Services.Interfaces;
using UnityEngine;

namespace Code.Services.UnityImplementations
{
	[Serializable]
	public class UnityUiService : IUiService
	{
		[field: SerializeField] public GameObject AppleView { get; private set; }
	}
}