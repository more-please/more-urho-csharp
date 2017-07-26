using Game.Utils;
using Urho;

namespace Game.Extensions
{
	public static class Materials
	{
		public static void SetUniforms(this Material material, BaseUniforms uniforms)
		{
			uniforms.SetInMaterial(material);
		}
	}
}
