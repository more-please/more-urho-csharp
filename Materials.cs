using Common.Utils;
using Urho;

namespace Common
{
	namespace Extensions
	{
		public static class Materials
		{
			public static void SetUniforms(this Material material, BaseUniforms uniforms)
			{
				uniforms.SetInMaterial(material);
			}
		}
	}
}
