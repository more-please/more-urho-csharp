using Urho.Actions;

namespace Game.Extensions
{
	public static class Actions
	{
		public static FiniteTimeAction RepeatForever(this FiniteTimeAction action)
		{
			return new RepeatForever(action);
		}
	}
}
