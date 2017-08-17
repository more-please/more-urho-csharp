using Urho;

namespace More.Urho
{
    public static class Materials
    {
        public static void SetUniforms(this Material material, BaseUniforms uniforms)
        {
            uniforms.SetInMaterial(material);
        }
    }
}
