using System.Collections.Generic;

namespace Game.Extensions
{
	public static class Enumerables
	{
		public static List<T> ToList<T>(this IEnumerable<T> items)
		{
			return new List<T>(items);
		}
	}
}
