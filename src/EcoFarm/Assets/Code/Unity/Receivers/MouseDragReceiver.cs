﻿
using UnityEngine;

namespace EcoFarm
{
	public class MouseDragReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;

		private GameEntity Entity => _viewListener.Entity;

		public void OnMouseDrag() => Entity.isDragging = true;
	}
}