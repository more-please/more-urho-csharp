using Urho.Gui;

namespace Game.Extensions
{
    public static class Text3Ds
    {
        public static float Height(this Text3D text) {
            return text.NumRows * text.RowHeight * text.RowSpacing;
        }
    }
}
