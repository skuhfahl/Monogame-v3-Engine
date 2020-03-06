using Microsoft.Xna.Framework;

namespace UntitledMedievalGame.Engine.Components
{
    /// <summary>
    /// Responsible for holding a Coordinate Vector2 (X, Y), Dimensions Vector2 (X, Y),
    /// and a Rotation float.
    /// </summary>
    class PositionComponent : IComponent
    {
        public Vector2 Position { get; set; }
        public Vector2 Dimensions { get; set; }
        public float Rotation { get; set; }
    }
}
