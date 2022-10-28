// ReSharper disable FieldCanBeMadeReadOnly.Global - For Entitas Visual Debugging
// ReSharper disable MemberCanBeProtected.Global - Too
namespace Code.Utils.Common
{
	public abstract class Interval<T>
	{
		public T StartValue;
		public T EndValue;

		protected Interval(T startValue, T endValue)
		{
			StartValue = startValue;
			EndValue = endValue;
		}

		public abstract bool IsContains(T value);
	}
}