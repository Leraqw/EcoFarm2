namespace Code.Utils.Common
{
	public abstract class Interval<T>
	{
		public Interval(T startValue, T endValue)
		{
			StartValue = startValue;
			EndValue = endValue;
		}

		public T StartValue { get; }
		public T EndValue { get; }

		public abstract bool IsContains(T value);
	}
}