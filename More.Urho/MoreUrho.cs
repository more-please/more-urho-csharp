using Urho;
using Urho.IO;
using Urho.Resources;

namespace More.Urho
{
	public abstract class MoreUrho
	{
		protected Log Log => Application.Current.Log;
		protected ResourceCache Cache => Application.Current.ResourceCache;
		protected Graphics Graphics => Application.Current.Graphics;
	}
}
