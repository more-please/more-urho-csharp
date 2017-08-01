using System.Collections;

namespace Game.Extensions
{
	public static class Collections
	{
		public static bool IsEmpty(this ICollection collection)
		{
			return collection.Count == 0;
		}
	}
}
