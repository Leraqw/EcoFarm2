using System.Collections.Generic;

namespace Code.Utils.Common
{
	public class Interval<T>
	{
		public Interval(T startValue, T endValue)
		{
			StartValue = startValue;
			EndValue = endValue;
		}

		public T StartValue { get; }
		public T EndValue { get; }

		public bool IsContains(T value) => Comparer<T>.Default.Compare(value, StartValue) >= 0
		                                   && Comparer<T>.Default.Compare(value, EndValue) <= 0;
	}
}