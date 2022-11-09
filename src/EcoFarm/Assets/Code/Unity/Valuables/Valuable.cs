using UnityEngine;

namespace Code.Unity.Valuables
{
	public abstract class Valuable : MonoBehaviour
	{
		public abstract int Value { get; }
	}
}