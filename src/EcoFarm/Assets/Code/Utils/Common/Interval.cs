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
	}
}