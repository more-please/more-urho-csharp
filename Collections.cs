using System.Collections.Generic;

namespace Game.Extensions
{
	public static class Collections
	{
		public static bool IsEmpty<T>(this ICollection<T> collection)
		{
			return collection.Count == 0;
		}
	}
}
